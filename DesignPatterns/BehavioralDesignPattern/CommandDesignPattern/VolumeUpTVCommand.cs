public class VolumeUpTVCommand : ICommand
{
    private readonly TV tv;

    public VolumeUpTVCommand(TV tv)
    {
        this.tv = tv;
    }

    public void Execute()
    {
        tv.VolumeUp();
    }
}