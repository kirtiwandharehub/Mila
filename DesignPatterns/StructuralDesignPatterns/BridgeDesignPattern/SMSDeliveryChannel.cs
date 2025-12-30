public class SMSDeliveryChannel : IDeliveryChannel
{
    private readonly string phoneNumber;

    public SMSDeliveryChannel(string phoneNumber)
    {
        this.phoneNumber = phoneNumber;
    }

    public void Deliver(string message)
    {
        Console.WriteLine($"SMS ({phoneNumber}). {message}");
    }
}