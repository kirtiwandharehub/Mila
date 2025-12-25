using System.Threading;

SalesRepresentative[] salesRepresentatives = new SalesRepresentative[3]
{
    new SalesRepresentative() {Name = "Sara"},
    new SalesRepresentative() {Name = "John"},
    new SalesRepresentative() {Name = "Marco"}
};
using CancellationTokenSource cts = new CancellationTokenSource();
Task[] tasks = new Task[3]
{
    salesRepresentatives[0].SalesRepresentativeTask(cts.Token),
    salesRepresentatives[1].SalesRepresentativeTask(cts.Token),
    salesRepresentatives[2].SalesRepresentativeTask(cts.Token)
};
cts.CancelAfter(TimeSpan.FromSeconds(10));

await Task.WhenAll(tasks);

Console.WriteLine($"{salesRepresentatives[0].Name} sold {salesRepresentatives[0].TotalSold}");
Console.WriteLine($"{salesRepresentatives[1].Name} sold {salesRepresentatives[1].TotalSold}");
Console.WriteLine($"{salesRepresentatives[2].Name} sold {salesRepresentatives[2].TotalSold}");

SalesDepartment sales = new SalesDepartment() {RetailPricePerItem = 10, WholeSalePricePerItem = 8};
sales.TotalSold = salesRepresentatives.Sum(sr => sr.TotalSold);
sales.ReportSales();