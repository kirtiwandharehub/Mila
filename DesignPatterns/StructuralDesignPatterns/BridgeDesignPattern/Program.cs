NotificationSystem securityNotificationSystem = new SecurityAlertNotification(new SMSDeliveryChannel("000-000-0000"));
securityNotificationSystem.Notify();

Console.WriteLine("----------------");

NotificationSystem orderNotificationSystem = new OrderNotification(new EmailDeliveryChannel("bluey@contoso.com"));
orderNotificationSystem.Notify();