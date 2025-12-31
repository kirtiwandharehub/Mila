public class WeatherMonitor
{
    private readonly List<IWeatherObserver> observers;
    private float temperature;

    public WeatherMonitor()
    {
        observers = new();    
    }

    public float Temperature
    {
        get { return temperature; }
        set 
        { 
            temperature = value;
            Notify();
        }        
    }

    public void Add(IWeatherObserver weatherObserver)
    {
        observers.Add(weatherObserver);
    }
    
    public void Remove(IWeatherObserver weatherObserver)
    {
        observers.Remove(weatherObserver);
    }

    public void Notify()
    {
        foreach(IWeatherObserver observer in observers)
        {
            observer.Update(temperature);
        }
    }
}