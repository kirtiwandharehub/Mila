public class SalesDepartment
{
    private Logger logger;
    public int TotalSold {get; set;}
    public int RetailPricePerItem {get; set;}
    public int WholeSalePricePerItem {get; set;}
    
    public void ReportSales()
    {
        int totalProfit = (RetailPricePerItem - WholeSalePricePerItem) * TotalSold;
        logger = Logger.GetInstance;
        logger.Log(
            $"TotalProfit - {totalProfit}.", 
            $" SoldToday - {TotalSold}.", 
            $" RetailPricePerItem - {RetailPricePerItem}.", 
            $" WholeSalePricePerItem - {WholeSalePricePerItem}.");
    }
}