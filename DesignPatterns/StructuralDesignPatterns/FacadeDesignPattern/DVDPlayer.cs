public class DVDPlayer
{
    public void On() => Console.WriteLine("DVD is turned on");

    public void Play(string name) => Console.WriteLine($"Playing {name} on DVD");

    public void Off() => Console.WriteLine("DVD is turned off");
}