Enemy enemy = new Enemy() {Name = "Zeta"};

enemy.SetEnemyBehavior(new AggressiveBehavior());
enemy.PerformAction();

await Task.Delay(TimeSpan.FromSeconds(1));

enemy.SetEnemyBehavior(new DefensiveBehavior());
enemy.PerformAction();

await Task.Delay(TimeSpan.FromSeconds(1));

enemy.SetEnemyBehavior(new FleeBehavior());
enemy.PerformAction();