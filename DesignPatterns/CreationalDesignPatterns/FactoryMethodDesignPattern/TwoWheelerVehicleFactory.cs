public class TwoWheelerVehicleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return new TwoWheelerVehicle();
    }
}