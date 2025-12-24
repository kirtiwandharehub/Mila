IVehicleFactory twoWheelerfactory = new TwoWheelerVehicleFactory();
IVehicleFactory threeWheelerfactory = new ThreeWheelerVehicleFactory();

IVehicle bike = twoWheelerfactory.CreateVehicle();
IVehicle rickshaw = threeWheelerfactory.CreateVehicle();

bike.Drive();
rickshaw.Drive();