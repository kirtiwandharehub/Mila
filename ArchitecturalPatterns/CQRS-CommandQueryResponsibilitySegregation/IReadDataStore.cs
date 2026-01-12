public interface IReadDataStore
{
    OrderReadModel Get(Guid orderId);

    void Upsert(OrderReadModel order);
}