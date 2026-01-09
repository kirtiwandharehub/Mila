public class OrderPlacedEvent
{
    public Guid OrderId { get; }
    public string CustomerEmail { get; }
    public string CustomerName { get; }
    public DateTime OccurredAt { get; }

    public OrderPlacedEvent(Guid orderId, string customerEmail, string customerName)
    {
        OrderId = orderId;
        CustomerEmail = customerEmail;
        CustomerName = customerName;
        OccurredAt = DateTime.UtcNow;
    }
}