public class ThreeWheelerVehicle : IVehicle
{    
    private ThreeWheelerVehicle() { }

    public void Drive()
    {
        Console.WriteLine("Drive ThreeWheelerVehicle");
    }

    public static ThreeWheelerVehicle Create()
    {
        return new ThreeWheelerVehicle();
    }
}