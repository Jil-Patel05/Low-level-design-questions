using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.CarRentalDesign
{
    public interface IPaymentStrategies
    {
        public void makePayment(double money);
    }
    public class CreditCardPayment : IPaymentStrategies
    {
        public void makePayment(double money)
        {
            Console.WriteLine("Credit card payment");
        }
    }
    public class DebitCardPayment : IPaymentStrategies
    {
        public void makePayment(double money)
        {
            Console.WriteLine("Debit card payment");
        }
    }
    public class UpiPayment : IPaymentStrategies
    {
        public void makePayment(double money)
        {
            Console.WriteLine("UPI payment");
        }
    }
}