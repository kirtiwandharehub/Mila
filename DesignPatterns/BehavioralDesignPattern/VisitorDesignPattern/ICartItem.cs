public interface ICartItem
{
    void Accept(ICartItemVisitor cartItemVisitor);
}