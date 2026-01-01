public abstract class ExpenseHandler : IExpenseHandler
{
    protected ExpenseHandler nextHandler;

    public ExpenseHandler SetNextHandler(ExpenseHandler nextHandler)
    {
        this.nextHandler = nextHandler;
        return nextHandler;
    }

    public bool TryHandle(ExpenseRequest expenseRequest)
    {
        if (CanHandle(expenseRequest))
        {
            Handle(expenseRequest);
            return true;
        }
        return nextHandler?.TryHandle(expenseRequest) ?? false;
    }

    protected abstract bool CanHandle(ExpenseRequest expenseRequest);

    protected abstract void Handle(ExpenseRequest expenseRequest);
}