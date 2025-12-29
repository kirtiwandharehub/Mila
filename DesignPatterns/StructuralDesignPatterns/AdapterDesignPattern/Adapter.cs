public class Adapter : ITarget
{
    private readonly Adaptee adaptee;

    public Adapter()
    {
        adaptee = new();
    }

    public void Play()
    {
        adaptee.LegacyPlay();
    }    
}