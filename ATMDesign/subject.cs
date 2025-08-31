using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLD_Q.ATMDesign
{
    public interface ISubject
    {
        public void addObserver(IObserver observer);
    }
    public class MoneyDebitedSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        public void addObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }
        public void removeObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void updateAllObserver()
        {
            foreach (IObserver item in observers)
            {
                item.update();
            }
        }
    }
}