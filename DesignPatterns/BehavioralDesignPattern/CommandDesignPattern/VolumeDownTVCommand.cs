public class VolumeDownTVCommand : ICommand
{
    private readonly TV tv;

    public VolumeDownTVCommand(TV tv)
    {
        this.tv = tv;
    }

    public void Execute()
    {
        tv.VolumeDown();
    }
}