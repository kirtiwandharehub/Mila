public class CityDisplayBoard : IWeatherObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"CityDisplayBoard: Temperature: {temperature} at {DateTime.Now}");
    }
}