using System.Collections.Concurrent;

public class ObjectPool<T> where T : class
{
    private readonly ConcurrentBag<T> bag;
    private Func<T> objectCreator;
    private int currentSize;
    private readonly int maxSize;

    public ObjectPool(int maxSize, Func<T> objectCreator)
    {
        this.maxSize = maxSize;
        this.currentSize = 0;
        this.bag = new ConcurrentBag<T>();
        this.objectCreator = objectCreator;
    }

    public T Aquire()
    {
        if (bag.TryTake(out T item))
        {
            return item;
        }

        if (Interlocked.Increment(ref currentSize) <= maxSize)
        {
            return objectCreator();
        }

        Interlocked.Decrement(ref currentSize);
        throw new InvalidOperationException("Pool is full.");
    }

    public void Release(T item)
    {
        bag.Add(item);
    }
}