public class Electronics : ICartItem
{
    public string Name { get; private set; }
    public double Price { get; private set; }
    public double Weight { get; private set; }

    public Electronics(string name, double price, double weight)
    {
        Name = name;
        Price = price;
        Weight = weight;
    }

    public void Accept(ICartItemVisitor cartItemVisitor)
    {
        cartItemVisitor.Visit(this);
    }
}