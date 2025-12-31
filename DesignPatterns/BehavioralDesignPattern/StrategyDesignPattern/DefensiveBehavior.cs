public class DefensiveBehavior : IEnemyBehavior
{
    public void Act(Enemy enemy)
    {
        Console.WriteLine($"{enemy.Name} defends at {DateTime.Now}.");
    }    
}