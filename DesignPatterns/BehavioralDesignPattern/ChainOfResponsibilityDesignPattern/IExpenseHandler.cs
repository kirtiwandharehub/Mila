public interface IExpenseHandler
{
    bool TryHandle(ExpenseRequest request);
}