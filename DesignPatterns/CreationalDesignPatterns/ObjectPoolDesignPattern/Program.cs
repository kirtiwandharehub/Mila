ObjectPool<DatabaseConnection> pool = new ObjectPool<DatabaseConnection>(3, () => new DatabaseConnection());
int failedExecutors = await StartExecutors(4);
if (failedExecutors > 0)
{
    Console.WriteLine("Retry failed executors once.");
    await StartExecutors(failedExecutors);
}

async Task<int> StartExecutors(int totalExecutors)
{
    List<Task> databaseTasks = new List<Task>();

    for(int i = 0; i < totalExecutors; i++)
    {
        databaseTasks.Add(DoDatabaseWork(i + 1));
    }

    int totalFailed = 0;
    try
    {
        await Task.WhenAll(databaseTasks);
    }
    catch
    {
        IEnumerable<Task> faultedTasks = databaseTasks.Where(t => t.IsFaulted);
        foreach(Task t in faultedTasks)
        {
            Console.WriteLine($"Task exception: {t.Exception.InnerException.Message}");
            totalFailed++;
        }
    }

    return totalFailed;
}

async Task DoDatabaseWork(int id)
{
    Console.WriteLine($"{id}: ----------------Start----------------");    
    Random r = new Random();
    await Task.Delay(TimeSpan.FromMilliseconds(r.Next(10, 30)));
    DatabaseConnection dbConn = pool.Aquire();
    await dbConn.Write($"{id}: Completed database operations for {id}");
    await Task.Delay(TimeSpan.FromMilliseconds(r.Next(10, 30)));
    pool.Release(dbConn);
    Console.WriteLine($"{id}: ----------------End----------------");
}

