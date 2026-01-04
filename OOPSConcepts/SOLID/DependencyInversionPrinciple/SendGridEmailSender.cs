public class SendGridEmailSender : IEmailSender
{
    public void SendEmail(string message, string receiverEmailAddress) => 
        Console.WriteLine($"Sending email via SednGrid. Message: {message} to {receiverEmailAddress}");
}