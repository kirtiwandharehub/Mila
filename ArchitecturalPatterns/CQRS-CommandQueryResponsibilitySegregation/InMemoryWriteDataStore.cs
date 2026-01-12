public class InMemoryWriteDataStore : IWriteDataStore
{
    private readonly List<Order> orders;

    public InMemoryWriteDataStore() => orders = new();


    public Order Get(Guid orderId) => orders.FirstOrDefault(o => o.OrderId == orderId);

    public void Add(Order order) => orders.Add(order);
}