using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StockTradingSystem
{
    public class Subject
    {
        private readonly List<IObserver> _observers; // Liste med observers

        public Subject() 
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
               _observers.Remove(observer);
        }

        public void Notify(Subject subject)
        {
            foreach (IObserver o in _observers) // Alle observers bliver opdateret
            {
                o.Update(subject);
            }
        }
    }
}
