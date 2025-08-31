using LLD_Q.LoggingDesign;
using LLD_questions.ParkingPlotDesign;
using Low_Level_Design_questions.ATMDesign;
using Low_Level_Design_questions.VendingMachineDesign;
using ParkingPlotDesign;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Parking plot design
            // Plot p1 = new Plot(PLOT_TYPE.CAR, 1, 1);
            // Plot p2 = new Plot(PLOT_TYPE.BIKE, 2, 1);
            // Plot p3 = new Plot(PLOT_TYPE.CAR, 1, 2);
            // Plot p4 = new Plot(PLOT_TYPE.BIKE, 2, 2);

            // ParkingPlot p = ParkingPlot.getInstance();
            // p.addPlots(p1);
            // p.addPlots(p2);
            // p.addPlots(p3);
            // p.addPlots(p4);

            // Vehicle v1 = new Car("ABCD1");
            // Vehicle v2 = new Bike("ABCD2");
            // Vehicle v3 = new Car("ABCD3");
            // Vehicle v4 = new Bike("ABCD4");

            // p.addVehicle(v1);
            // p.addVehicle(v2);
            // p.addVehicle(v3);
            // p.addVehicle(v4);

            // Vending machine
            // Product p1 = new Product("A", 1, 2);
            // Product p2 = new Product("B", 2, 2);
            // Product p3 = new Product("C", 3, 2);
            // Product p4 = new Product("D", 4, 2);

            // Shelf s1 = new Shelf(p1, "1");
            // Shelf s2 = new Shelf(p2, "2");
            // Shelf s3 = new Shelf(p3, "3");
            // Shelf s4 = new Shelf(p4, "4");

            // VendingMachine v = VendingMachine.getInstance();
            // v.initializeMachine();

            // v.addShelfs(s1);
            // v.addShelfs(s2);
            // v.addShelfs(s3);
            // v.addShelfs(s4);

            // v.startButtonClicked();
            // v.enteredId("1", 1);
            // v.setItems(2);
            // v.purchaseProduct(PAYMENT_STRATEGIES.UPI_PAYMENT);
            // // v.displayItems();
            // v.startButtonClicked();
            // v.enteredId("1", 1);

            // ATM Machine
            // Account acc = new Account("ABCD", 838);
            // Card card = new Card(acc, "1234");

            // ATMMachine am = new ATMMachine();
            // am.addCash((int)CASH_TYPE.CASH_500, 20);
            // am.addCash((int)CASH_TYPE.CASH_200, 20);
            // am.addCash((int)CASH_TYPE.CASH_100, 20);
            // am.addCash((int)CASH_TYPE.CASH_50, 20);
            // am.addCash((int)CASH_TYPE.CASH_20, 20);
            // am.addCash((int)CASH_TYPE.CASH_10, 20);
            // am.addCash((int)CASH_TYPE.CASH_5, 20);
            // am.addCash((int)CASH_TYPE.CASH_2, 20);
            // am.addCash((int)CASH_TYPE.CASH_1, 20);

            // am.insetCard(card);
            // am.enterPIN("1234");
            // am.selectOperation(OPERATIONS.VIEW_BALANCE);
            // am.insetCard(card);
            // am.enterPIN("1234");
            // am.selectOperation(OPERATIONS.WITHDRAW_CASH, 838);

            // Logging system
            Logger logger = Logger.getInstance();
            logger.initializeLogger();
            logger.logMessage("Hey info", LOG_TYPE.INFO);
            logger.logMessage("Hey debug", LOG_TYPE.DEBUG);
            logger.logMessage("Hey error", LOG_TYPE.ERROR);
            logger.logMessage("Hey warning", LOG_TYPE.WARNING);
        }
    }

}