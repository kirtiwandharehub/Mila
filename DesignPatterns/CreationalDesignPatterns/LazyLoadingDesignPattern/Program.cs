// Using manual lazy loading
Console.WriteLine("------Using manual lazy loading--------");
ExpensiveObjectManualClient manualClient = new();
manualClient.ExpensiveObject.DoWork("Manual client 1");
manualClient.ExpensiveObject.DoWork("Manual client 2");
// Using Lazy class
Console.WriteLine("------Using Lazy class--------");
ExpensiveObjectLazyClient lazyClient = new();
lazyClient.ExpensiveObject.DoWork("Lazy client 1");
lazyClient.ExpensiveObject.DoWork("Lazy client 2");
// Using Virtual Proxy
Console.WriteLine("------Using Virtual Proxy--------");
IEmployees employees = new EmployeesProxy();
employees.DisplayEmployees();
Console.WriteLine();
employees.DisplayEmployees();