using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LLD_questions.ParkingPlotDesign;

namespace ParkingPlotDesign
{
    public class ParkingPlot
    {
        // Plot size ie here
        private List<Plot> plots = new List<Plot>();
        private static ParkingPlot instance;
        private static object obj = new object();

        private ParkingPlot()
        {

        }

        public static ParkingPlot getInstance()
        {
            if (instance == null)
            {
                lock (obj)
                {
                    if (instance == null)
                    {
                        instance = new ParkingPlot();
                    }
                }

            }
            return instance;
        }

        public void addPlots(Plot p)
        {
            plots.Add(p);
        }

        public void addVehicle(Vehicle vehicle)
        {
            bool isVehicleAdded = false;
            foreach (Plot pl in plots)
            {
                if (pl.plotType == vehicle.plotType && !pl.isPlotOccupied)
                {
                    pl.isPlotOccupied = true;
                    pl.vehicle = vehicle;
                    isVehicleAdded = true;
                    break;
                }
            }
            // parking slip
            if (!isVehicleAdded)
            {
                Console.WriteLine("There is no space for this vehicle");
            }
            else
            {
                Console.WriteLine("Vehicle added");
            }
        }

        private void ProcessPayment(PAYMENT_STRATEGY ps)
        {

        }

        public void removeVehicle(Vehicle vehicle, PAYMENT_STRATEGY ps)
        {
            Plot removedElement = plots.FirstOrDefault(plot => plot.vehicle.numberPlate == vehicle.numberPlate);
            if (removedElement != null)
            {
                this.ProcessPayment(ps);
                removedElement.isPlotOccupied = false;
                removedElement.vehicle = null;
                Console.WriteLine("Payment is done, Plot released");
            }
            else
            {
                Console.WriteLine("You have not car registered using this number");
            }
        }
    }
}