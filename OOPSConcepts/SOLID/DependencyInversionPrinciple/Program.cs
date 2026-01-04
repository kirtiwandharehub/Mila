SmtpEmailSender smtpEmailSender = new();
NotificationSystem notificationSystem = new NotificationSystem(smtpEmailSender);

notificationSystem.SendNotification("You order is getting prepared !!", "abc@contoso.com");
notificationSystem.SendNotification("Thanks for placing the order !!", "xyz@contoso.com");

await Task.Delay(TimeSpan.FromMicroseconds(1));

// Change email sender
SendGridEmailSender sendGridEmailSender = new();
notificationSystem = new NotificationSystem(sendGridEmailSender);

notificationSystem.SendNotification("Your order is delivered !!", "abc@contoso.com");
notificationSystem.SendNotification("Your order is on the way !!", "xyz@contoso.com");