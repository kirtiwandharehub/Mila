public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;
    
    protected CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual string Description => coffee.Description;

    public virtual double Cost => coffee.Cost;
}