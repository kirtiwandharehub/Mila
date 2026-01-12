public class GetOrderQueryHandler
{
    private readonly IReadDataStore readDataStore;

    public GetOrderQueryHandler(IReadDataStore readDataStore) => this.readDataStore = readDataStore;

    public OrderReadModel Handle(GetOrderQuery getOrderQuery)
    {
        return readDataStore.Get(getOrderQuery.OrderId);
    }
}