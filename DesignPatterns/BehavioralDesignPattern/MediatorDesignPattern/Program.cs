IChatMediator chatMediator = new ChatMediator();

IChatUser chatUser1 = new ChatUser("Peppa", chatMediator);
IChatUser chatUser2 = new ChatUser("Mickey", chatMediator);
IChatUser chatUser3 = new ChatUser("Daisy", chatMediator);

chatMediator.RegisterChatUser(chatUser1);
chatMediator.RegisterChatUser(chatUser2);
chatMediator.RegisterChatUser(chatUser3);

chatUser1.SendChat("Good Morning everyone!!");
Console.WriteLine();
chatUser2.SendChat("Hi everyone");
Console.WriteLine();
chatUser3.SendChat("How are you all?");