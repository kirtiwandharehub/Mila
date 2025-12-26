public class Pizza
{
    public bool Cheese { get; set; }
    public bool Tomatoes { get; set; }
    public bool Pepperoni { get; set; }

    private Pizza() {}

    public class Builder
    {
        private readonly Pizza pizza = new Pizza();

        public Builder AddCheese() 
        { 
            pizza.Cheese = true; 
            return this;
        }
        
        public Builder AddTomatoes() 
        { 
            pizza.Tomatoes = true;
            return this;
        }
        
        public Builder AddPepperoni() 
        { 
            pizza.Pepperoni = true; 
            return this;
        }

        public Pizza Build() => pizza;
    }

    public override string ToString()
    {
        return $"Pizza choices. Cheese: {Cheese}. Pepperoni: {Pepperoni}. Tomatoes: {Tomatoes}";
    }
}
