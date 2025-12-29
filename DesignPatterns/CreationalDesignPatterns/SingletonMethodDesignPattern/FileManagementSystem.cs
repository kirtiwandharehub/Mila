public sealed class FileManagementSystem
{
    private static Lazy<FileManagementSystem> instance = new Lazy<FileManagementSystem>();
    public static FileManagementSystem GetInstance() => instance.Value;

    public async Task Append(string filePath, string message)
    {
        await File.AppendAllTextAsync(filePath, message);
    }
}
