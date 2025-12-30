public abstract class NotificationSystem
{
    protected readonly IDeliveryChannel deliveryChannel;

    protected NotificationSystem(IDeliveryChannel channel)
    {
        this.deliveryChannel = channel;
    }

    public abstract void Notify();
}