public class DatabaseConnection
{
    public async Task Write(string data)
    {
        Task.Delay(TimeSpan.FromMilliseconds(1));
        Console.WriteLine($"Wrote - {data}");
    }
}