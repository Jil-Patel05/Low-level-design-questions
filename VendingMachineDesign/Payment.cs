using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.VendingMachineDesign
{
    public enum PAYMENT_STRATEGIES
    {
        CREDIT_CARD_PAYMENT,
        DEBIT_CARD_PAYMENT,
        UPI_PAYMENT,
    }
    public class Payment
    {
        private IPaymentStrategies paymentStrategies;
        public Payment()
        {
        }

        public void setPayment(IPaymentStrategies paymentStrategies)
        {
            this.paymentStrategies = paymentStrategies;
        }

        public void makePayment(double money)
        {
            this.paymentStrategies.makePayment(money);
        }
    }
}