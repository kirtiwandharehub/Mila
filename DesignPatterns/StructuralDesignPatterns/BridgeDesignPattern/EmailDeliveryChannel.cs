public class EmailDeliveryChannel : IDeliveryChannel
{
    private readonly string email;

    public EmailDeliveryChannel(string email)
    {
        this.email = email;
    }

    public void Deliver(string message)
    {
        Console.WriteLine($"Email ({email}). {message}");
    }
}