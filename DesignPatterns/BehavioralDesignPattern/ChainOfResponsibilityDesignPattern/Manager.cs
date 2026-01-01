public class Manager : ExpenseHandler
{
    protected override bool CanHandle(ExpenseRequest expenseRequest) => 
        expenseRequest.Amount <= 5000;

    protected override void Handle(ExpenseRequest expenseRequest) => 
        Console.WriteLine($"Manager: Approved request for {expenseRequest.Amount}");
}