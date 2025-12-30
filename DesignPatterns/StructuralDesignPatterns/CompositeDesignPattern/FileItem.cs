public class FileItem : FileSystemComponent
{
    public FileItem(string name) : base(name) {}

    public override void Display(int depth)
    {
        Console.WriteLine($"{new string('-', depth)} {Name}(File)");
    }
}