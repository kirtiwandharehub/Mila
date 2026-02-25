TokenBucket tokenBucket = new TokenBucket(5, 2);
int totalAllowed = 0;
int totalRejected = 0;
Console.WriteLine("---------------------------Reject request---------------------------");
Parallel.For(0, 30, i =>
{
    if (tokenBucket.AllowRequest())
    {
        Console.WriteLine($"Thread {i}: Request ALLOWED at {DateTime.Now:HH:mm:ss.fff}");
        totalAllowed++;
    }
    else
    {
        Console.WriteLine($"Thread {i}: Request REJECTED at {DateTime.Now:HH:mm:ss.fff}");
        totalRejected++;
    }
});
Console.WriteLine($"All requests processed. TotalAllowed: {totalAllowed} TotalRejected: {totalRejected}");

Console.WriteLine("---------------------------Throttle request---------------------------");
tokenBucket = new TokenBucket(5, 2);
totalAllowed = 0;
totalRejected = 0;
Parallel.For(0, 20, i =>
{
    while (!tokenBucket.AllowRequest())
    {
        Task.Delay(500).Wait();
    }
    Console.WriteLine($"Thread {i}: Request PROCESSED at {DateTime.Now:HH:mm:ss.fff}");
    totalAllowed++;
});
Console.WriteLine($"All requests processed. TotalAllowed: {totalAllowed} TotalRejected: {totalRejected}");