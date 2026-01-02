public class GreenTrafficLightState : ITrafficLightState
{
    public ITrafficLightState Next()
    {
        return new YellowTrafficLightState();
    }
    
    public string Color => "Green";
}