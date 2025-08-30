using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.ATMDesign
{
    public enum OPERATIONS
    {
        WITHDRAW_CASH,
        VIEW_BALANCE
    }
    public class ATMMachine
    {
        private Card card;
        private Account account;
        private IState currentState;
        private ATMMachineInv anv;
        private Dictionary<int, int> moneyToReturn;

        public ATMMachine()
        {
            this.currentState = new IdleState();
            this.anv = new ATMMachineInv();
        }

        public void setCurrentState(IState state)
        {
            this.currentState = state;
        }

        public void insetCard(Card card)
        {
            try
            {
                if (this.currentState is IdleState)
                {
                    // Some of basic checks perform here to validated
                    this.card = card;
                    this.account = card.account;
                    this.currentState.nextState(this);
                }
                else
                {
                    throw new Exception("Method not allowed in this state");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
        }

        public bool enterPIN(string PIN)
        {
            if (this.currentState is HasCard)
            {
                if (this.card.isPINValid(PIN))
                {
                    this.currentState.nextState(this);
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void withDrawCash(double money)
        {
            if (this.currentState is ProcessOperationState)
            {
                bool isCashRemoved = this.account.debitMoney(money);
                if (isCashRemoved)
                {
                    this.moneyToReturn = this.anv.debitMoney(money);
                    if (moneyToReturn != null)
                    {
                        this.currentState.nextState(this);
                        this.dispachMoney();
                    }
                    else
                    {
                        Console.WriteLine("ATM has not sufficient money to debit");
                    }
                }
                else
                {
                    Console.WriteLine("Your account has not sufficient money to debit");
                }
            }
        }

        public void addCash(int cashType, int number)
        {
            this.anv.addCash(cashType, number);
        }

        private void dispachMoney()
        {
            foreach (KeyValuePair<int, int> item in this.moneyToReturn)
            {
                Console.WriteLine($"Money item {item.Key} of {item.Value}");
            }
            this.currentState.nextState(this);
        }
        private void viewBalance()
        {
            if (this.currentState is ProcessOperationState)
            {
                Console.WriteLine($"Your current balance is {this.account.money}");
                this.setCurrentState(new IdleState());
            }
        }

        public void selectOperation(OPERATIONS op, double money = 0)
        {
            if (this.currentState is SelectOperationState)
            {
                if (op == OPERATIONS.WITHDRAW_CASH)
                {
                    this.currentState.nextState(this);
                    this.withDrawCash(money);
                }
                else
                {
                    this.currentState.nextState(this);
                    this.viewBalance();
                }
            }
        }
    }
}