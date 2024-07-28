using ObserverPattern.ObserverClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class Observer
    {
        public static void ExecuteObserver()
        {
            Stock stock = new Stock();
            Investor investor1 = new Investor("Investor 1");
            Investor investor2 = new Investor("Investor 2");

            // Register investors
            stock.RegisterObserver(investor1);
            stock.RegisterObserver(investor2);

            // Change the stock price and notify investors
            stock.SetPrice(100.0f);
            stock.SetPrice(150.0f);

            // Remove an investor and change the stock price
            stock.RemoveObserver(investor1);
            stock.SetPrice(200.0f);
        }
    }
}
