public class TwoWheelerVehicle : IVehicle
{    
    private TwoWheelerVehicle() { }

    public void Drive()
    {
        Console.WriteLine("Drive TwoWheelerVehicle");
    }

    public static TwoWheelerVehicle Create()
    {
        return new TwoWheelerVehicle();
    }
}