public class ConcreteHouseBuilder : IHouseBuilder
{
    private readonly House house = new House();

    public void BuildFoundation()
    {
        house.Foundation = "Concrete foundation";
    }

    public void BuildWalls()
    {
        house.Walls = "Wodden walls";
    }

    public void BuildRoof()
    {
        house.Roof = "Metal roof";
    }

    public House BuildHouse()
    {
        return house;
    }
}