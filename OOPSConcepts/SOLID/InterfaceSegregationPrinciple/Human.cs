public class Human : IWorkable, IEatable
{
    public void Work() => Console.WriteLine("Human Working");

    public void Eat() => Console.WriteLine("Human Eating");
}