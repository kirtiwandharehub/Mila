public class OrderProjection
{
    private readonly IReadDataStore readDataStore;

    public OrderProjection(IReadDataStore readDataStore) => this.readDataStore = readDataStore;

    public void Handle(OrderCreatedEvent @event)
    {
        readDataStore.Upsert(new OrderReadModel(@event.OrderId, @event.CustomerName, "Created"));
    }

    public void Handle(OrderCancelledEvent @event)
    {
        OrderReadModel orderReadModel = readDataStore.Get(@event.OrderId);

        if (orderReadModel is not null)
        {
            readDataStore.Upsert(orderReadModel with {Status = "Cancelled"});
        }        
    }
}