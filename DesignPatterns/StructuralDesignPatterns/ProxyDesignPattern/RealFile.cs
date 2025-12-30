public class RealFile : IFile
{
    private readonly string fileName;

    public RealFile(string fileName)
    {
        this.fileName = fileName;
        LoadFile();
    }

    public void Read()
    {
        Console.WriteLine($"Reading file {fileName}.");
    }

    private void LoadFile()
    {
        Console.WriteLine($"Loading file {fileName}.");
    }
}