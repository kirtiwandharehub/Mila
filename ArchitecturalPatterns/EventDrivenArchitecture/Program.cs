// Event Bus
EventBus eventBus = new();

// Subscribers
InventoryService inventoryService = new();
EmailService emailService = new();

// Subscribe
eventBus.Subscribe<OrderPlacedEvent>(inventoryService.OnOrderPlaced);
eventBus.Subscribe<OrderPlacedEvent>(emailService.OnOrderPlaced);

// Order Service
OrderService orderService = new OrderService(eventBus);

// Order 1
orderService.PlaceOrder(new Customer("Lisa", "Lisa@abc.com"));

Console.WriteLine();

// Order 2
orderService.PlaceOrder(new Customer("Mike", "Mike@abc.com"));