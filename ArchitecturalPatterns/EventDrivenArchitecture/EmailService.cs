public class EmailService
{
    public void OnOrderPlaced(OrderPlacedEvent orderEvent)
    {
        Console.WriteLine($"[EmailService] Sending order confirmation email to {orderEvent.CustomerEmail}");
    }
}