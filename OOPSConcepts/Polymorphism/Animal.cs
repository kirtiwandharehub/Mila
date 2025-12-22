
namespace OOPSConcepts.Polymorphism
{
    public enum Speed
    {
        Regular,
        Slow,
        Fast
    }

    public class Animal
    {
        public string Name {get; set;}
        
        public void Walk()
        {
            Console.WriteLine($"{Name} is walking at {Speed.Regular} speed.");
        }

        public void Walk(Speed speed)
        {
            Console.WriteLine($"{Name} is walking at {speed} speed.");
        }

        public virtual void WhoAmI()
        {
            Console.WriteLine($"Hmmm... My name is {Name}. Let's find out more from a derived class");
        }
    }

    public class Cat : Animal
    {
        public override void WhoAmI()
        {
            Console.WriteLine($"My name is {Name}. I am a cat.");
        }
    }
}