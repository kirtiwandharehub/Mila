public class RedEnemyAI : EnemyAI
{
    protected override void DecideAction()
    {
        Console.WriteLine("DecideAction: chase the target");
    }

    protected override void Act()
    {
        Console.WriteLine("Act: Attack the target");
    }
}