public class YellowTrafficLightState : ITrafficLightState
{
    public ITrafficLightState Next()
    {
        return new RedTrafficLightState();
    }
    
    public string Color => "Yellow";
}