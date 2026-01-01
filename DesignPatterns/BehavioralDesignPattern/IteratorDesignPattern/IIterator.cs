public interface IIterator<T>
{
    bool MoveNext();
    void Reset();
    T Current { get; }
}