public class Order
{
    public Guid Id { get; }
    public Customer Customer { get; }
    public DateTime CreatedAt { get; }

    private Order(Guid id, Customer customer)
    {
        Id = id;
        Customer = customer;
        CreatedAt = DateTime.UtcNow;
    }

    public static Order Create(Customer customer)
    {
        return new Order(Guid.NewGuid(), customer);
    }
}