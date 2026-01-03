public class PriceCalculatorVisitor : ICartItemVisitor
{
    public double TotalPrice { get; private set; }

    public void Visit(Book book)
    {
        TotalPrice += book.Price;
    }

    public void Visit(Electronics electronics)
    {   
        TotalPrice += electronics.Price;
    }
}