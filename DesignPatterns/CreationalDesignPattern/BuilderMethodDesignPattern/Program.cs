// Using Director class
ConstructionDirector director = new ConstructionDirector(new ConcreteHouseBuilder());
House concreteHouse = director.Construct();
Console.WriteLine("---------------Using Director class---------------");
Console.WriteLine(concreteHouse);

// Using fluent Builder pattern
Pizza pepperoniPizza = new Pizza.Builder().AddCheese().AddTomatoes().AddPepperoni().Build();
Pizza cheesePizza = new Pizza.Builder().AddCheese().Build();
Console.WriteLine("---------------Fluent Builder pattern---------------");
Console.WriteLine(pepperoniPizza);
Console.WriteLine(cheesePizza);