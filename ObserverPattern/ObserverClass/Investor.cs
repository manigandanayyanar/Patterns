using ObserverPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.ObserverClass
{
    public class Investor : IObserver
    {
        private string _name;
        private float _price;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(float price)
        {
            _price = price;
            Console.WriteLine($"Notified {_name} of price change to {price}");
        }
    }

}
