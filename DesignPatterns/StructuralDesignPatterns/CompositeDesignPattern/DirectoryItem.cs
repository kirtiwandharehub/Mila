public class DirectoryItem : FileSystemComponent
{
    private List<FileSystemComponent> children;
    public DirectoryItem(string name) : base(name)
    {
        children = new();
    }

    public void Add(FileSystemComponent item)
    {
        children.Add(item);
    }

    public void Remove(FileSystemComponent item)
    {
        children.Remove(item);
    }

    public override void Display(int depth)
    {
        Console.WriteLine($"{new string('-', depth)} {Name}(Directory)");
        foreach (FileSystemComponent component in children)
        {
            component.Display(depth + 2);
        }
    }
}