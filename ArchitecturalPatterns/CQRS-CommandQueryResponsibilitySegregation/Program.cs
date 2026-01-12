// CQRS setup

// Write datastore
IWriteDataStore writeDataStore = new InMemoryWriteDataStore();

// Event broker
IEventBus eventBus= new InMemoryEventBus();

// Command handlers and event producer
CreateOrderCommandHandler createOrderCommandHandler = new CreateOrderCommandHandler(writeDataStore, eventBus);
CancelOrderCommandHandler cancelOrderCommandHandler = new CancelOrderCommandHandler(writeDataStore, eventBus);

// Read data store
IReadDataStore readDataStore = new InMemoryReadDataStore();

// Order projection
OrderProjection orderProjection= new OrderProjection(readDataStore);

// Projection subscribers
eventBus.Subscribe<OrderCreatedEvent>(orderProjection.Handle);
eventBus.Subscribe<OrderCancelledEvent>(orderProjection.Handle);

// Query Handler
GetOrderQueryHandler getOrderQueryHandler = new GetOrderQueryHandler(readDataStore);

// Simulate order creation
Guid orderId1 = Guid.NewGuid();
createOrderCommandHandler.Handle(new CreateOrderCommand(orderId1, "Sera"));
Guid orderId2 = Guid.NewGuid();
createOrderCommandHandler.Handle(new CreateOrderCommand(orderId2, "Mike"));

// Read order
Console.WriteLine($"Order details: {getOrderQueryHandler.Handle(new GetOrderQuery(orderId1))}");
Console.WriteLine($"Order details: {getOrderQueryHandler.Handle(new GetOrderQuery(orderId2))}");

// Simulate order cancellation
cancelOrderCommandHandler.Handle(new CancelOrderCommand(orderId1));

// Read order
Console.WriteLine();
Console.WriteLine($"Order details: {getOrderQueryHandler.Handle(new GetOrderQuery(orderId1))}");
Console.WriteLine($"Order details: {getOrderQueryHandler.Handle(new GetOrderQuery(orderId2))}");