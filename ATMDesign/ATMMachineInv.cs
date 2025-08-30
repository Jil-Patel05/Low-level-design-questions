using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.ATMDesign
{
    public enum CASH_TYPE
    {
        CASH_500 = 500,
        CASH_100 = 100,
        CASH_50 = 50,
        CASH_20 = 20,
        CASH_10 = 10,
        CASH_5 = 5,
        CASH_2 = 2,
        CASH_ = 1
    }
    public class ATMMachineInv
    {
        Dictionary<CASH_TYPE, int> map = new Dictionary<CASH_TYPE, int>();
        public ATMMachineInv()
        {

        }

        public void addCash(CASH_TYPE cashType, int number)
        {
            map[cashType] += number;
        }
        public bool isSufficientCash(CASH_TYPE cashType, int number)
        {
            return map[cashType] >= number;
        }
        public void removeCash(CASH_TYPE cashType, int number)
        {
            if (isSufficientCash(cashType, number))
            {
                map[cashType] -= number;
            }
        }

        public bool isSufficientMoneyToDebit(double money)
        {
            // Check Total money we have present at this time
            double totalMoney = 0;
            foreach (KeyValuePair<CASH_TYPE, int> item in map)
            {
                totalMoney += (int)item.Key * item.Value;
            }

            return totalMoney >= money;
        }

        public Dictionary<CASH_TYPE, int> debitMoney(double money)
        {
            if (!isSufficientMoneyToDebit(money))
            {
                return null;
            }

            double moneyLeft = money;
            Dictionary<CASH_TYPE, int> moneyToReturn = new Dictionary<CASH_TYPE, int>();
            foreach (KeyValuePair<CASH_TYPE, int> item in map)
            {
                if (moneyLeft == 0)
                {
                    break;
                }
                int dividend = (int)moneyLeft / (int)item.Key;
                int mn = Math.Min(dividend, item.Value);
                this.removeCash(item.Key, mn);
                moneyLeft -= mn * (int)item.Key;
                moneyToReturn[item.Key] = mn;
            }
            return moneyToReturn;
        }
    }
}