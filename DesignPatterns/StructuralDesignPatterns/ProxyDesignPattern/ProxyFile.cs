public class ProxyFile : IFile
{
    private readonly Lazy<RealFile> lazyFile;
    private readonly bool hasAccess;

    public ProxyFile(string fileName, bool hasAccess)
    {
        this.hasAccess = hasAccess;
        lazyFile = new Lazy<RealFile>(() => new RealFile(fileName));
    }

    public void Read()
    {
        if (hasAccess)
        {
            lazyFile.Value.Read();
        }
        else
        {
            Console.WriteLine("Access denied.");
        }
    }
} 