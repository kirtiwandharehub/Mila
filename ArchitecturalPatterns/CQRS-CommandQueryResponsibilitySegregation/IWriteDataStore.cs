public interface IWriteDataStore
{
    Order Get(Guid orderId);
    
    void Add(Order order);
}