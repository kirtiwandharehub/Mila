public class FleeBehavior : IEnemyBehavior
{
    public void Act(Enemy enemy)
    {
        Console.WriteLine($"{enemy.Name} flees at {DateTime.Now}.");
    }    
}