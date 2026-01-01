public class GreenEnemyAI : EnemyAI
{
    protected override void DecideAction()
    {
        Console.WriteLine("DecideAction: Keep distance from the target");
    }

    protected override void Move()
    {
        Console.WriteLine("Move: Moving toward a safe place");
    }

    protected override void Act()
    {
        Console.WriteLine("Act: Fire");
    }
}