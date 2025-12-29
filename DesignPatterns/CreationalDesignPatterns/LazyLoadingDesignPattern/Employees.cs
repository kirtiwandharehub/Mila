public class Employees : IEmployees
{
    private List<Employee> employees;

    public Employees()
    {
        Console.WriteLine("Employees initialized.");
        PopulateEmployees();
    }

    public void DisplayEmployees()
    {
        foreach(Employee employee in employees)
        {
            Console.WriteLine($"{employee.Name} - {employee.Id}");
        }
    }

    private void PopulateEmployees()
    {
        employees = new List<Employee>()
        {
            new Employee() { Name = "John", Id = 1},
            new Employee() { Name = "Sara", Id = 2},
            new Employee() { Name = "Alex", Id = 3}
        };
    }
}
