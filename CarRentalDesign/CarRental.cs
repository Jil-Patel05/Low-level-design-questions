using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Low_Level_Design_questions.CarRentalDesign;

namespace LLD_Q.CarRentalDesign
{
    public class CarRental
    {
        private IList<Car> cars = new List<Car>();
        private IList<BookedCar> bookedCars = new List<BookedCar>();
        private Payment payment;

        public CarRental(Payment payment)
        {
            this.payment = payment;
        }

        public void addCars(Car car)
        {
            this.cars.Add(car);
        }

        public void AddBookedCars(BookedCar car)
        {
            this.bookedCars.Add(car);
        }

        private void PrintCars(IList<Car> resultedCars)
        {
            foreach (Car item in resultedCars)
            {
                Console.WriteLine($"Car with number{item.CarNumber} of {item.CarSize} is available, for booking car enter carNumbe to");
            }
        }

        public void searchCar(string city, string state, string country, DateTime pickupTime, DateTime dropTime)
        {
            IList<Car> resultedCars = this.cars.Where((car) => car.location.City == city && car.location.State == state && car.location.Country == country).ToList();
            resultedCars = resultedCars.Where((car) => car.bookedTo < pickupTime).ToList();
            this.PrintCars(resultedCars);
        }

        private void bookTheCar(string carModel)
        {
            // We have to handle concurrency Here
            // Make sure than we have booked car and carNumber for that car reduced
            // And now we have to wait for payment to be done
            this.payment.setPayment(new UpiPayment());
            this.payment.makePayment(120);
            // Add car in bookedCar
        }

        private void returnCar(string carNumber)
        {

        }
    }
}