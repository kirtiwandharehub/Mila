public class ShippingCostVisitor : ICartItemVisitor
{
    public double ShippingCost { get; private set; }

    public void Visit(Book book)
    {
        ShippingCost += 2;
    }

    public void Visit(Electronics electronics)
    {   
        ShippingCost += electronics.Weight * 3;
    }
}