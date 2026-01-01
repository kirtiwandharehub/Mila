public class Director : ExpenseHandler
{
    protected override bool CanHandle(ExpenseRequest expenseRequest) => 
        expenseRequest.Amount <= 10000;

    protected override void Handle(ExpenseRequest expenseRequest) => 
        Console.WriteLine($"Director: Approved request for {expenseRequest.Amount}");
}