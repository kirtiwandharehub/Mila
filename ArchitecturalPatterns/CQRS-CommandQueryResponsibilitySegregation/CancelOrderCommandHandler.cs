public class CancelOrderCommandHandler
{
    private readonly IWriteDataStore writeDataStore;
    private readonly IEventBus eventBus;

    public CancelOrderCommandHandler(IWriteDataStore writeDataStore, IEventBus eventBus)
    {
        this.writeDataStore = writeDataStore;
        this.eventBus = eventBus;
    }    

    public void Handle(CancelOrderCommand command)
    {
        Order order = writeDataStore.Get(command.OrderId);

        if (order is not null)
        {
            order.Cancel();
            eventBus.Publish(new OrderCancelledEvent(command.OrderId));
        }    
    }
}