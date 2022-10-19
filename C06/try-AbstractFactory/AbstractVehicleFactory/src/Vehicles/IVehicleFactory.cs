using Vehicles.Models;
using Vehicles.Models.Try;

namespace Vehicles;
public interface IVehicleFactory
{
    ICar CreateCar();
    IBike CreateBike();
}