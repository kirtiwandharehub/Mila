public sealed record Money(decimal Amount)
{
    public static Money Zero => new(0);

    public Money Add(Money newMoney)
    {
        ArgumentNullException.ThrowIfNull(newMoney);

        return new Money(Amount + newMoney.Amount);
    }
}