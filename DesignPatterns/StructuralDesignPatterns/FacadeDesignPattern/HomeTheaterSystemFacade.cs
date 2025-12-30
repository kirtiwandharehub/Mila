public class HomeTheaterSystemFacade
{
    private readonly SoundSystem soundSystem;
    private readonly DVDPlayer dvdPlayer;
    private readonly Projector projector;

    public HomeTheaterSystemFacade()
    {
        this.soundSystem = new SoundSystem();
        this.dvdPlayer = new DVDPlayer();
        this.projector = new Projector();
    }

    public void Start(int volume, string name)
    {
        Console.WriteLine("Starting the home theater system.");
        projector.On();
        soundSystem.On();
        projector.SetWideScreen();
        soundSystem.SetVolume(volume);
        dvdPlayer.On();
        dvdPlayer.Play(name);
    }

    public void Stop()
    {
        Console.WriteLine("Stoping the home theater system.");
        dvdPlayer.Off();
        projector.Off();
        soundSystem.Off();
    }
}