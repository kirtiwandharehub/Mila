public class Enemy
{
    public string Name { get; set; }
    private IEnemyBehavior enemyBehavior;

    public void SetEnemyBehavior(IEnemyBehavior eb) => enemyBehavior = eb;

    public void PerformAction() => enemyBehavior.Act(this);
}