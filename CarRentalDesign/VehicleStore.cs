using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.CarRentalDesign
{
    public class Location
    {
        public string city;
        public Location(string city){
            this.city = city;
        }
    }
    public class VehicleStore
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        public Location location;
        public VehicleStore()
        {
            
        }

        public void addVehicle(Vehicle vehicle)
        {
            vehicles.Add(vehicle);
        }

        public void removeVehicle(string number)
        {
            vehicles = this.vehicles.Where((vehicle) => vehicle.vehicleNumber != number).ToList();
        }

        public IList<Vehicle> getAvailableVehicle(VEHICLE_TYPE vehicleType)
        {
            IList<Vehicle> availableVehicles = new List<Vehicle>();
            foreach (Vehicle item in vehicles)
            {
                if (item.vehicleType == vehicleType && item.vehicleStatus == VEHICLE_STATUS.AVAILABLE)
                {
                    availableVehicles.Add(item);
                }
            }
            return availableVehicles;
        }

    }
}