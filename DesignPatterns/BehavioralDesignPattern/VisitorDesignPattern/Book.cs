public class Book : ICartItem
{
    public string Title { get; private set; }
    public double Price { get; private set; }

    public Book(string title, double price)
    {
        Title = title;
        Price = price;
    }

    public void Accept(ICartItemVisitor cartItemVisitor)
    {
        cartItemVisitor.Visit(this);
    }
}