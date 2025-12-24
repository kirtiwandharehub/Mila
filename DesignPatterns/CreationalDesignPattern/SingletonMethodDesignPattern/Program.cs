//Perform some operations
int ShoesSoldToday() => 100;
int RetailPricePerShoe() => 70;
int WholeSalePricePerShoe() => 50;
int TotalProfitMadeToday() => (RetailPricePerShoe() - WholeSalePricePerShoe()) * ShoesSoldToday();

Logger logger = Logger.GetInstance;
logger.Log(
    $"TotalProfitMadeToday - {TotalProfitMadeToday()}.", 
    $" ShoesSoldToday - {ShoesSoldToday()}.", 
    $" RetailPricePerShoe - {RetailPricePerShoe()}.", 
    $" WholeSalePricePerShoe - {WholeSalePricePerShoe()}.");