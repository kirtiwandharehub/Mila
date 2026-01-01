TeamLead teamLead = new();
teamLead.
    SetNextHandler(new Manager()).
    SetNextHandler(new Director());

double[] expenses = {1000, 5000, 10000, 20000};

foreach(double expense in expenses)
{
    if(!teamLead.TryHandle(new ExpenseRequest(expense)))
    {
        Console.WriteLine($"Expense {expense} could not be approved");
    }
}
