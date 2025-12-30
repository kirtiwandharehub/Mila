public  abstract class FileSystemComponent
{
    public string Name { get; }

    protected FileSystemComponent(string name) => Name = name;

    public abstract void Display(int depth);
}