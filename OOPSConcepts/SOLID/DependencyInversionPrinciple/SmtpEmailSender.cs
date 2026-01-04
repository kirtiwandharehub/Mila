public class SmtpEmailSender : IEmailSender
{
    public void SendEmail(string message, string receiverEmailAddress) =>
        Console.WriteLine($"Sending email via Smtp. Message: {message} to {receiverEmailAddress}");
}