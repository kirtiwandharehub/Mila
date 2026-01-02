public class RedTrafficLightState : ITrafficLightState
{
    public ITrafficLightState Next()
    {
        return new GreenTrafficLightState();
    }
    
    public string Color => "Red";
}