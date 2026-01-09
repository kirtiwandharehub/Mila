public class OrderService
{
    private readonly EventBus eventBus;

    public OrderService(EventBus eventBus)
    {
        this.eventBus = eventBus;
    }

    public Order PlaceOrder(Customer customer)
    {
        Order order = Order.Create(customer);
        Console.WriteLine($"[OrderService] Order {order.Id} created for customer {customer.Name}");

        OrderPlacedEvent orderPlacedEvent = new OrderPlacedEvent(order.Id, customer.Email, customer.Name);

        eventBus.Publish(orderPlacedEvent);

        return order;
    }
}