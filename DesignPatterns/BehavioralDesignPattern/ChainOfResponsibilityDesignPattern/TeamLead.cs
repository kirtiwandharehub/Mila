public class TeamLead : ExpenseHandler
{
    protected override bool CanHandle(ExpenseRequest expenseRequest) => 
        expenseRequest.Amount <= 1000;

    protected override void Handle(ExpenseRequest expenseRequest) => 
        Console.WriteLine($"Team Lead: Approved request for {expenseRequest.Amount}");
}