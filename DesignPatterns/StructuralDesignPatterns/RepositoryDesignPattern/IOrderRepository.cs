public interface IOrderRepository
{
    Order GetById(Guid Id);
    void Save(Order order);
}