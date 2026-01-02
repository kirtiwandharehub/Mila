public class ChatUser : IChatUser
{
    public string Name { get; private set; }
    private IChatMediator chatMediator;

    public ChatUser(string name, IChatMediator chatMediator)
    {
        Name = name;
        this.chatMediator = chatMediator;
    }

    public void SendChat(string message)
    {
        Console.WriteLine($"{Name} sent message: {message}");
        chatMediator.SendChat(message, this);
    }

    public void ReceiveChat(string message)
    {
        Console.WriteLine($"{Name} received message: {message}");
    }
}