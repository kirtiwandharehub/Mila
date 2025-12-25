public class SalesRepresentative
{
    private Logger logger;
    public string Name {get; private set;}
    public int TotalSold {get; private set;}
    private string filePath;
    private FileManagementSystem fileMS;

    public SalesRepresentative(string name)
    {
        this.Name = name;
        this.filePath = $"Transactions-{name}.txt";
    }
    
    public void Sold(int quantity)
    {
        TotalSold += quantity;
        logger = Logger.GetInstance;
        logger.Log($"{Name} sold {quantity} items.");
    }

    public async Task UpdateTransactions()
    {
        fileMS = FileManagementSystem.GetInstance();
        await fileMS.Append(filePath, $"{DateTime.Now} - Total Sold - {TotalSold}.{Environment.NewLine}");
    }

    public async Task SalesRepresentativeTask(CancellationToken ct)
    {
        Random random = new Random();
        while(!ct.IsCancellationRequested)
        {
            int num = random.Next(1, 20);
            if (num % 2 == 0)
            {
                Sold(1);
            }
            
            await Task.Delay(TimeSpan.FromSeconds(2));
        }
    }
}