public abstract class EnemyAI : IEnemyAI
{
    public void UpdateAI()
    {
        SenseEnvironment();
        DecideAction();
        Move();
        Act();
    }

    protected void SenseEnvironment()
    {
        Console.WriteLine("SenseEnvironment: Sensing the environment");
    }

    protected abstract void DecideAction();

    protected virtual void Move()
    {
        Console.WriteLine("Move: Moving toward the target");
    }

    protected virtual void Act()
    {
        
    }
}