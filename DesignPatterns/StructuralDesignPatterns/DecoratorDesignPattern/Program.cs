// Customer 0 ordered coffee with milk. Print receipt
ICoffee plainCoffee = new PlainCoffee();
Console.WriteLine("---------Customer 0 Receipt------------");
Console.WriteLine($"{plainCoffee.Description}. Price - ${plainCoffee.Cost}");
// Customer 1 ordered coffee with milk. Print receipt
plainCoffee = new PlainCoffee();
ICoffee milkCoffee = new MilkCoffeeDecorator(plainCoffee);
Console.WriteLine("---------Customer 1 Receipt------------");
Console.WriteLine($"{milkCoffee.Description}. Price - ${milkCoffee.Cost}");
// Customer 2 ordered coffee with sugar. Print receipt
plainCoffee = new PlainCoffee();
ICoffee sugarCoffee = new SugarCoffeeDecorator(plainCoffee);
Console.WriteLine("---------Customer 2 Receipt------------");
Console.WriteLine($"{sugarCoffee.Description}. Price - ${sugarCoffee.Cost}");
// Customer 3 ordered coffee with milk and sugar. Print receipt
plainCoffee = new PlainCoffee();
milkCoffee = new MilkCoffeeDecorator(plainCoffee);
ICoffee milkSugarCoffee = new SugarCoffeeDecorator(milkCoffee);
Console.WriteLine("---------Customer 3 Receipt------------");
Console.WriteLine($"{milkSugarCoffee.Description}. Price - ${milkSugarCoffee.Cost}");
