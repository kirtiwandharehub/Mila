IVehicleFactory twoWheelerfactory = new TwoWheelerVehicleFactory();
IVehicleFactory threeWheelerfactory = new ThreeWheelerVehicleFactory();

// Create a bike
IVehicle bike = twoWheelerfactory.CreateVehicle();
// Create a rickshaw
IVehicle rickshaw = threeWheelerfactory.CreateVehicle();

bike.Drive();
rickshaw.Drive();