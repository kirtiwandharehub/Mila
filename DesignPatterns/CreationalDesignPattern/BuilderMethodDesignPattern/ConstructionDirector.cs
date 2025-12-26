public class ConstructionDirector
{
    private readonly IHouseBuilder builder;

    public ConstructionDirector(IHouseBuilder builder)
    {
        this.builder = builder;
    }

    public House Construct()
    {
        builder.BuildFoundation();
        builder.BuildWalls();
        builder.BuildRoof();
        return builder.BuildHouse();
    }
}
