public class InventoryService
{
    public void OnOrderPlaced(OrderPlacedEvent orderEvent)
    {
        Console.WriteLine($"[InventoryService] Reserving inventory for order {orderEvent.OrderId}");
    }
}