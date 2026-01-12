public class Order
{
    public Guid OrderId { get; set; }
    public string CustomerName { get; set; }
    public string Status { get; set; }

    public Order(Guid orderId, string customerName)
    {
        OrderId = orderId;
        CustomerName = customerName;
        Status = "Created";
    }

    public void Cancel()
    {
        Status = "Cancelled";
    }
}