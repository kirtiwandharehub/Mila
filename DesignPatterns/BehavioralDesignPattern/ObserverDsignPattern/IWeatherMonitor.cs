public interface IWeatherMonitor
{
    void Add(IWeatherObserver weatherObserver);
    void Remove(IWeatherObserver weatherObserver);
    void Notify();
}