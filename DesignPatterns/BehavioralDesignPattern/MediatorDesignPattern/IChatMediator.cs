public interface IChatMediator
{
    void SendChat(string message, IChatUser sender);
    
    void RegisterChatUser(IChatUser chatUser);
}