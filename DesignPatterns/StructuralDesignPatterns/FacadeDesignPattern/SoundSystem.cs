public class SoundSystem
{
    public void On() => Console.WriteLine("SoundSystem is turned on");

    public void SetVolume(int volume) => Console.WriteLine($"Set volume to {volume}");

    public void Off() => Console.WriteLine("SoundSystem is turned off");
}