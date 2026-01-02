TrafficLight trafficLight = new();

for(int i = 0; i < 5; i++)
{
    Console.WriteLine($"Current Light: {trafficLight.Color}");
    trafficLight.Change();
    await Task.Delay(TimeSpan.FromMilliseconds(1));
}

