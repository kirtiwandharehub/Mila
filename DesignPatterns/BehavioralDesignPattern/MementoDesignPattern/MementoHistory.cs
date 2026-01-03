public class MementoHistory
{
    private readonly Stack<IMemento> stack;

    public MementoHistory()
    {
        stack = new Stack<IMemento>();
    }

    public void Add(IMemento memento) => stack.Push(memento);

    public IMemento Get() => stack.Pop();    
}