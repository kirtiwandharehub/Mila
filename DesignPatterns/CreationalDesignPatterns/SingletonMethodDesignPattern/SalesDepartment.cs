public class SalesDepartment
{
    private Logger logger;
    public int TotalSold {get; set;}
    public int RetailPricePerItem {get; set;}
    public int WholeSalePricePerItem {get; set;}
    public int TotalProfit() => (RetailPricePerItem - WholeSalePricePerItem) * TotalSold;
    private string filePath = @"SalesBook.txt";
    private FileManagementSystem fileMS;
    
    public void ReportSales()
    {   
        logger = Logger.GetInstance;
        logger.Log(
            $"TotalProfit - {TotalProfit()}.", 
            $" SoldToday - {TotalSold}.", 
            $" RetailPricePerItem - {RetailPricePerItem}.", 
            $" WholeSalePricePerItem - {WholeSalePricePerItem}.");
    }

    public async Task UpdateInventory()
    {
        fileMS = FileManagementSystem.GetInstance();
        await fileMS.Append(filePath, $"{DateTime.Now} - TotalProfit - {TotalProfit()}.{Environment.NewLine}");
    }
}