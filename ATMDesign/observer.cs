using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.ATMDesign
{
    public interface IObserver
    {
        public void update();
    }
    public class MoneyDebitedObserver : IObserver
    {
        public void update()
        {
            Console.WriteLine("Money debited");
        }
    }
}