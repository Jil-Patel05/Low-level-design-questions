using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LLD_questions.ParkingPlotDesign;

namespace ParkingPlotDesign
{
    public enum PLOT_TYPE
    {
        BIKE,
        CAR,
        TRUCK
    }

    public enum HOUR_PRICE
    {
        PER_HOUR = 10,
    }

    public enum PAYMENT_STRATEGY
    {
        CREDIT_CARD,
        DEBIT_CARD,
        UPI,
        NET_BANKING
    }
    public class Plot
    {
        public PLOT_TYPE plotType;
        public int plotNumber;
        public int floor;
        public bool isPlotOccupied = false;
        public Vehicle vehicle;

        public Plot(PLOT_TYPE plotType, int plotNumber, int floor)
        {
            this.plotType = plotType;
            this.plotNumber = plotNumber;
            this.floor = floor;
        }

    }
}