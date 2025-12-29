public class ExpensiveObjectLazyClient
{
    private readonly Lazy<ExpensiveObject> obj = new Lazy<ExpensiveObject>(() => new ExpensiveObject());
    public ExpensiveObject ExpensiveObject => obj.Value;
}