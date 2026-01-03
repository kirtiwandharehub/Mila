Human human = new Human();
Robot robot= new Robot();

StartWork(human);
StartWork(robot);

await Task.Delay(TimeSpan.FromMicroseconds(1));

StartLunch(human);

void StartWork(IWorkable workable) => workable.Work();

void StartLunch(IEatable eatable) => eatable.Eat();