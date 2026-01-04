public interface IEmailSender
{
    void SendEmail(string message, string receiverEmailAddress);
}