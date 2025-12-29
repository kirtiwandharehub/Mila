public class ThreeWheelerVehicleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new ThreeWheelerVehicle();
    }
}