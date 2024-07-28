using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverClass
{
    public class Stock : ISubject
    {
        private List<IObserver> _observers;
        private float _price;

        public Stock()
        {
            _observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_price);
            }
        }

        public void SetPrice(float price)
        {
            _price = price;
            NotifyObservers();
        }
    }

}
