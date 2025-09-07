using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.CarRentalDesign
{
    public enum CAR_SIZE
    {
        SMALL,
        MEDIUM,
        LARGE,
        EXTRA_LARGE
    }
    public class Car
    {
        public string CarNumber { get; private set; }
        public double CarFuel { get; private set; }
        public double CarPrice { get; private set; }
        public CAR_SIZE CarSize { get; private set; } // pessanerLimit, LuggageLimit
        public Location location { get; private set; }
        public DateTime bookedFrom { get; private set; }
        public DateTime bookedTo { get; private set; }

        public Car(string carNumber, double carFuel, double carprice, CAR_SIZE carSize, Location location)
        {
            this.CarNumber = carNumber;
            this.CarFuel = carFuel;
            this.CarPrice = carprice;
            this.CarSize = carSize;
            this.location = location;
        }

        public void booktheCar(DateTime start, DateTime end)
        {
            this.bookedFrom = start;
            this.bookedTo = end;
        }

        public void changeTheCarPrice(double price)
        {
            this.CarPrice = price;
        }

        public void setCarFuel(double carFuel)
        {
            this.CarFuel = carFuel;
        }
    }
    public class BookedCar
    {
        public Car car;
        public User user;
        public DateTime bookingTime;
        public bool isPaymentFullyDone;
        public double bookedCarPrice;
        public double priceGiven;
        public DateTime carBookedFrom;
        public DateTime carBookedTo;

        public BookedCar(Car car, User user, DateTime bookingTime, bool isPaymentFullyDone, double bookedCarPrice, double priceGiven, DateTime carBookedFrom, DateTime carBookedTo)
        {
            this.car = car;
            this.user = user;
            this.bookingTime = bookingTime;
            this.isPaymentFullyDone = isPaymentFullyDone;
            this.bookedCarPrice = bookedCarPrice;
            this.priceGiven = priceGiven;
            this.carBookedFrom = carBookedFrom;
            this.carBookedTo = carBookedTo;
        }
    }
}