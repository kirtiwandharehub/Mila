public class NotificationSystem
{
    private readonly IEmailSender emailSender;

    public NotificationSystem(IEmailSender emailSender)
    {
        this.emailSender = emailSender;
    }

    public void SendNotification(string message, string receiverEmailAddress)
    {
        emailSender.SendEmail(message, receiverEmailAddress);
    }
}