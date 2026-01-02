public interface ITrafficLightState
{
    ITrafficLightState Next();
    
    string Color { get; }
}