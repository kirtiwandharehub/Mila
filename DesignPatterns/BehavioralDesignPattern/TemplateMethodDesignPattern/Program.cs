Console.WriteLine("-----Green Enemy-------------");
IEnemyAI greenEnemy = new GreenEnemyAI();
greenEnemy.UpdateAI();

Console.WriteLine("-----Red Enemy-------------");
IEnemyAI redEnemy = new RedEnemyAI();
redEnemy.UpdateAI();