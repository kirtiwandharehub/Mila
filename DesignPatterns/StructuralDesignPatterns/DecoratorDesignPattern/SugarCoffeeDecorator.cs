public class SugarCoffeeDecorator : CoffeeDecorator
{
    public SugarCoffeeDecorator(ICoffee coffee) : base(coffee)
    {}

    public override string Description => $"{coffee.Description} with Sugar";
    
    public override double Cost => coffee.Cost + 0.25;
}