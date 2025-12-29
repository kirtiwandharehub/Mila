public class ExpensiveObject
{
    public ExpensiveObject() => Console.WriteLine("Heavy object initialized");
    
    public void DoWork(string message) => Console.WriteLine($"Complete work for {message}");
}
