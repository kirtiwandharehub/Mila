public class TwoWheelerVehicleFactory : IVehicleFactory
{
    public IVehicle CreateVehicle()
    {
        return TwoWheelerVehicle.Create();
    }
}