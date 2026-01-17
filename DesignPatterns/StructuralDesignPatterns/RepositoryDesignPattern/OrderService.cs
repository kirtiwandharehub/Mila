using System.Data.SqlTypes;

public class OrderService
{
    private readonly IOrderRepository orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        this.orderRepository = orderRepository;
    }

    public Order GetOrder(Guid orderId)
    {
        return orderRepository.GetById(orderId);
    }

    public void AddAmount(Guid orderId, Money amount)
    {
        Order order = GetOrder(orderId);
        order.AddAmount(amount);
        orderRepository.Save(order);
    }

    public void PayOrder(Guid orderId)
    {
        Order order = GetOrder(orderId);
        order.Pay();
        orderRepository.Save(order);
    }

    public void CreateOrder(Guid id)
    {
        orderRepository.Save(new Order(id));
    }
}