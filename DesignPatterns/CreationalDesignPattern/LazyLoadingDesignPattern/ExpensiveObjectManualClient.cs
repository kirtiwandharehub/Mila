public class ExpensiveObjectManualClient
{
    private ExpensiveObject obj;

    public ExpensiveObject ExpensiveObject
    {
        get
        {
            if (obj == null)
            {
                obj = new ExpensiveObject();
            }
            return obj;
        }
    }
}