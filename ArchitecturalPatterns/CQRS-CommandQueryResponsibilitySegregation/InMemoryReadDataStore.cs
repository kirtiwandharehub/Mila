public class InMemoryReadDataStore : IReadDataStore
{
     private readonly Dictionary<Guid, OrderReadModel> orders;

    public InMemoryReadDataStore() => orders = new();

    public OrderReadModel Get(Guid orderId) => orders.TryGetValue(orderId, out OrderReadModel orderReadModel) ? orderReadModel : null;

    public void Upsert(OrderReadModel orderReadModel) => orders[orderReadModel.OrderId] = orderReadModel;
}