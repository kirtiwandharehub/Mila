public interface IChatUser
{
    void SendChat(string message);
    
    void ReceiveChat(string message);
}