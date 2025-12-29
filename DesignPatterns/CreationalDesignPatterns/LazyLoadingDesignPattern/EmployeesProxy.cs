public class EmployeesProxy : IEmployees
{
    private Employees employees;

    public void DisplayEmployees()
    {
        if (employees == null)
        {
            employees = new Employees();
        }
        employees.DisplayEmployees();
    }
}
