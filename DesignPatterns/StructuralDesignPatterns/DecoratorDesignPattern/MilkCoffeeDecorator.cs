public class MilkCoffeeDecorator : CoffeeDecorator
{
    public MilkCoffeeDecorator(ICoffee coffee) : base(coffee)
    {}

    public override string Description => $"{coffee.Description} with Milk";
    
    public override double Cost => coffee.Cost + 0.50;
}