using System.Data.SqlTypes;

public class Order
{
    public Guid Id { get; set;}
    public Money Total {get; private set;}
    public bool IsPaid {get; private set;}

    public Order(Guid Id)
    {
        this.Id = Id;
        Total = Money.Zero;
        IsPaid = false;
    }

    public void AddAmount(Money amount)
    {
        if (amount == null)
        {
            throw new ArgumentNullException(nameof(amount));
        }

        Total = Total.Add(amount);
    }

    public void Pay()
    {
        if (Total.Amount <= 0)
        {
            throw new InvalidOperationException("Amount is zero or less");
        }
        IsPaid = true;
    }
}