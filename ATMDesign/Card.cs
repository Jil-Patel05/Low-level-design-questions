using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Low_Level_Design_questions.ATMDesign
{
    public class Card
    {
        public Account account;
        public string PIN;

        public Card(Account account, string PIN)
        {
            this.account = account;
            this.PIN = PIN;
        }

        public bool isPINValid(string PIN)
        {
            return this.PIN == PIN;
        }

        // SET the PIN Again
    }
}