using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ParkingPlotDesign;

namespace LLD_questions.ParkingPlotDesign
{
    public abstract class Vehicle
    {
        public string numberPlate;
        public PLOT_TYPE plotType;

        public Vehicle(string numberPlate, PLOT_TYPE plotType)
        {
            this.numberPlate = numberPlate;
            this.plotType = plotType;
        }
    }

    public class Car : Vehicle
    {
        public Car(string numberPlate) : base(numberPlate, PLOT_TYPE.CAR)
        {
        }
    }
    public class Bike : Vehicle
    {
        public Bike(string numberPlate) : base(numberPlate, PLOT_TYPE.BIKE)
        {
        }
    }
}