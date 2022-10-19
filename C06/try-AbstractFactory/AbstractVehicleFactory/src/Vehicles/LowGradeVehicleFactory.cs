using Vehicles.Models.Try;

namespace Vehicles;

public class LowGradeVehicleFactory: IVehicleFactory
{
    public IBike CreateBike() => new LowGradeBike();
    public ICar CreateCar() => new LowGradeCar();
}