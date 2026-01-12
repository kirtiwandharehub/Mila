public class CreateOrderCommandHandler
{
    private readonly IWriteDataStore writeDataStore;
    private readonly IEventBus eventBus;

    public CreateOrderCommandHandler(IWriteDataStore writeDataStore, IEventBus eventBus)
    {
        this.writeDataStore = writeDataStore;
        this.eventBus = eventBus;
    }    

    public void Handle(CreateOrderCommand command)
    {
        writeDataStore.Add(new Order(command.OrderId, command.CustomerName));
        eventBus.Publish(new OrderCreatedEvent(command.OrderId, command.CustomerName));
    }
}