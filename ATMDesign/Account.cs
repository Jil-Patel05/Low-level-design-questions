using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.ATMDesign
{
    public class Account
    {
        public string accountNumber;
        public double money;
        public Account(string accountNumber, double money)
        {
            this.accountNumber = accountNumber;
            this.money = money;
        }

        private bool isSufficientMoney(double moneyToDebited)
        {
            return this.money >= moneyToDebited;
        }

        public bool debitMoney(double moneyToDebited)
        {
            if (isSufficientMoney(moneyToDebited))
            {
                this.money -= moneyToDebited;
                return true;
            }
            // Send message to user using kafka or anything
            return false;
        }

        public void creditMoney(double moneyToDebited)
        {
            this.money += moneyToDebited;
        }
    }
}