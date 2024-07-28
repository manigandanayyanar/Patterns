using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADEPattern.FACDEClass
{
    public class ShippingSystem
    {
        public void ShipProduct(string productId, string address)
        {
            Console.WriteLine("Shipping product: " + productId + " to address: " + address);
        }
    }
}
