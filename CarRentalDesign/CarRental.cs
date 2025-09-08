using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.CarRentalDesign
{
    public class CarRental
    {
        public IList<VehicleStore> stores = new List<VehicleStore>();
        public IList<Vehicle> availableVehicle = new List<Vehicle>();
        public CarRental()
        {

        }

        public void AddVehicleStore(VehicleStore vs)
        {
            this.stores.Add(vs);
        }

        public void getAllVehicle(VEHICLE_TYPE vt, string city)
        {
            foreach (VehicleStore item in stores)
            {
                if (item.location.city == city)
                {
                    availableVehicle = item.getAvailableVehicle(vt);
                }
            }
            foreach (Vehicle item in availableVehicle)
            {
                Console.WriteLine($"We have vehicle of type{item.vehicleType} available and car number is{item.vehicleNumber}");
            }
        }

        public void bookVehicle(string number, User user)
        {
            Vehicle? v = this.availableVehicle.Where((v) => v.vehicleNumber == number).FirstOrDefault();
            if (v != null)
            {
                // Getting base rent of vehicle
                double baseRent = v.baseRent;
                // Perform Payment here using payment strategy which user select;
                // Make new Registration here
                // U can make use of Registration manager to manage everything
                v.bookVehicle();
            }
        }

        public void dropVehicle(string number, User user)
        {
            // Make vehicle available
            // And get user notified
        }

        public void cancelTheRegistration(Guid guid, User usr)
        {
            // Cancel the registration here            
        }
    }
}