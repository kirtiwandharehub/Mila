using System.Data.SqlTypes;

OrderService orderService = new OrderService(new InMemoryOrderRepository());

Guid order1Id = Guid.NewGuid();
orderService.CreateOrder(order1Id);
orderService.AddAmount(order1Id, new Money(10.00m));    
orderService.PayOrder(order1Id);
Order order1 = orderService.GetOrder(order1Id);

Console.WriteLine($"Order 1: Id: {order1.Id} Amount: {order1.Total} Paid: {order1.IsPaid}");

Guid order2Id = Guid.NewGuid();
orderService.CreateOrder(order2Id);
orderService.AddAmount(order2Id, new Money(20.00m));    
orderService.AddAmount(order2Id, new Money(50.00m));  
Order order2 = orderService.GetOrder(order2Id);

Console.WriteLine($"Order 2: Id: {order2.Id} Amount: {order2.Total} Paid: {order2.IsPaid}");