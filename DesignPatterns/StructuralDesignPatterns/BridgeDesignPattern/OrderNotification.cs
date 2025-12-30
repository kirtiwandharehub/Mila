public class OrderNotification : NotificationSystem
{
    public OrderNotification(IDeliveryChannel deliveryChannel) : base(deliveryChannel) {}

    public override void Notify()
    {
        deliveryChannel.Deliver("Order update. Order is being processed.");
    }
}