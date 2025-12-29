public class House
{
    public string Foundation { get; set; }
    public string Walls { get; set; }
    public string Roof { get; set; }

    public override string ToString()
    {
        return $"House config. Fondation: {Foundation}. Walls: {Walls}. Roof: {Roof}";
    }
}
