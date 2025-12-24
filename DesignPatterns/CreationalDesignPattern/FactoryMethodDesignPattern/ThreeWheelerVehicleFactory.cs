public class ThreeWheelerVehicleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return ThreeWheelerVehicle.Create();
    }
}