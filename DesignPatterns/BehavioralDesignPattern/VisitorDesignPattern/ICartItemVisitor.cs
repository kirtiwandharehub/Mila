public interface ICartItemVisitor
{
    void Visit(Book book);
    
    void Visit(Electronics electronics);
}