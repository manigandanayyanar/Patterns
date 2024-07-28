using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADEPattern.FACDEClass
{
    public class InventorySystem
    {
        public void CheckInventory(string productId)
        {
            Console.WriteLine("Checking inventory for product: " + productId);
        }

        public void ReserveProduct(string productId)
        {
            Console.WriteLine("Reserving product: " + productId);
        }
    }

}
