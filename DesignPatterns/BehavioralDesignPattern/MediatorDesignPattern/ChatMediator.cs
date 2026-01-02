public class ChatMediator : IChatMediator
{
    private List<IChatUser> chatUsers;

    public ChatMediator()
    {
        chatUsers = new List<IChatUser>();
    }

    public void RegisterChatUser(IChatUser chatUser) => chatUsers.Add(chatUser);

    public void SendChat(string message, IChatUser sender)
    {
        foreach(IChatUser chatUser in chatUsers)
        {
            if (chatUser != sender)
            {
                chatUser.ReceiveChat(message);
            }
        }
    }
}