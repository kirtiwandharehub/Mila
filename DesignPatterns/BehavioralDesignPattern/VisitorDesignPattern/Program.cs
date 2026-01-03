List<ICartItem> cart = new List<ICartItem>()
{
    new Book("Mickey Mouse", 10),
    new Electronics("TV", 1000, 50),
    new Book("Peppa Pig", 15),
    new Electronics("Laptop", 500, 10),
};

PriceCalculatorVisitor priceCalculatorVisitor = new PriceCalculatorVisitor();
ShippingCostVisitor shippingCostVisitor = new ShippingCostVisitor();

foreach(ICartItem item in cart)
{
    item.Accept(priceCalculatorVisitor);
    item.Accept(shippingCostVisitor);
}

Console.WriteLine($"Total Price: {priceCalculatorVisitor.TotalPrice}");
Console.WriteLine($"Shipping Cost: {shippingCostVisitor.ShippingCost}");

