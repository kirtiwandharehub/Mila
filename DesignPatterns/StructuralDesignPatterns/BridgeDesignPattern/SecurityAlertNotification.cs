public class SecurityAlertNotification : NotificationSystem
{
    public SecurityAlertNotification(IDeliveryChannel deliveryChannel) : base(deliveryChannel) {}

    public override void Notify()
    {
        deliveryChannel.Deliver("Security Alert!! - Check you account.");
    }
}