public class InMemoryOrderRepository : IOrderRepository
{
    private readonly Dictionary<Guid, Order> orderStore;

    public InMemoryOrderRepository()
    {
        orderStore = [];
    }

    public Order GetById(Guid id)
    {
        if (orderStore.TryGetValue(id, out Order order))
        {
            return order;
        }
        else
        {
            throw new KeyNotFoundException($"Order {id} not found");
        }
    }

    public void Save(Order order)
    {
        orderStore[order.Id] = order;
    }
}