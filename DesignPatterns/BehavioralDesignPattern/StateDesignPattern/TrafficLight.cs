public class TrafficLight
{
    private ITrafficLightState trafficLightState;

    public TrafficLight()
    {
        trafficLightState = new RedTrafficLightState();
    }

    public void Change()
    {
        trafficLightState = trafficLightState.Next();
    }

    public string Color => trafficLightState.Color;
}