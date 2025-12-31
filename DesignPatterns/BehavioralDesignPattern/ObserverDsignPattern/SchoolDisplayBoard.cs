public class SchoolDisplayBoard : IWeatherObserver
{
    public void Update(float temperature)
    {
        Console.WriteLine($"SchoolDisplayBoard: Temperature: {temperature} at {DateTime.Now}");
    }
}