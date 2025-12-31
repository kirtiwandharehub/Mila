CityDisplayBoard cityDisplayBoard = new();
SchoolDisplayBoard schoolDisplayBoard = new();

WeatherMonitor weatherMonitor = new();

weatherMonitor.Add(cityDisplayBoard);
weatherMonitor.Add(schoolDisplayBoard);

weatherMonitor.Temperature = 55.30F;
await Task.Delay(TimeSpan.FromSeconds(1));
weatherMonitor.Temperature = 60.30F;

weatherMonitor.Remove(cityDisplayBoard);

await Task.Delay(TimeSpan.FromSeconds(1));
weatherMonitor.Temperature = 65.30F;

