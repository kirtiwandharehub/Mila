public class AggressiveBehavior : IEnemyBehavior
{
    public void Act(Enemy enemy)
    {
        Console.WriteLine($"{enemy.Name} shows aggression at {DateTime.Now}.");
    }    
}