using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.CarRentalDesign
{
    public enum VEHICLE_TYPE
    {
        CAR,
        BIKE,
        SMALL_CAR,
        XUV,
        MUV
    }
    public enum VEHICLE_STATUS
    {
        AVAILABLE,
        BOOKING_INPROGRESS,
        BOOKED
    }
    public enum BASE_PAY_OF_CARS
    {
        CAR = 100,
        BIKE = 50,
        SMALL_CAR = 80,
        XUV = 150,
        MUV = 180
    }
    public class Vehicle
    {
        public string vehicleNumber;
        public VEHICLE_TYPE vehicleType;
        public double baseRent;
        public VEHICLE_STATUS vehicleStatus;

        public Vehicle(string vehicleNumber, VEHICLE_TYPE vehicleType, double baseRent)
        {
            this.vehicleNumber = vehicleNumber;
            this.vehicleType = vehicleType;
            this.vehicleStatus = VEHICLE_STATUS.AVAILABLE;
            this.baseRent = baseRent;
        }

        public void bookVehicle()
        {
            this.vehicleStatus = VEHICLE_STATUS.BOOKED;
        }

        public void dropVehicle()
        {
            this.vehicleStatus = VEHICLE_STATUS.AVAILABLE;
        }
    }

    // Car extend vehicle -> 
}