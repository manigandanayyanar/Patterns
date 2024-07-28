using FACADEPattern.FACDEClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADEPattern
{
    public class OrderFacade(InventorySystem inventorySystem, PaymentSystem paymentSystem, ShippingSystem shippingSystem)
    {
        private InventorySystem _inventorySystem = inventorySystem;
        private PaymentSystem _paymentSystem = paymentSystem;
        private ShippingSystem _shippingSystem = shippingSystem;

        public void PlaceOrder(string productId, string paymentDetails, string address)
        {
            _inventorySystem.CheckInventory(productId);
            _inventorySystem.ReserveProduct(productId);
            _paymentSystem.ProcessPayment(paymentDetails);
            _shippingSystem.ShipProduct(productId, address);
        }
    }

}
