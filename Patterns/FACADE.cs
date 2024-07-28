using FACADEPattern;
using FACADEPattern.FACDEClass;
using FACADEPattern.FACDEClass.BankingClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class FACADE
    {
        public static void PlaceOrderFacade()
        {
            InventorySystem inventorySystem = new();
            PaymentSystem paymentSystem = new();
            ShippingSystem shippingSystem = new();

            OrderFacade orderFacade = new(inventorySystem, paymentSystem, shippingSystem);

            orderFacade.PlaceOrder("Product123", "PaymentDetails456", "Address789");
        }

        public static void BankingFacade()
        {
            AccountSystem accountSystem = new();
            LoanSystem loanSystem = new();
            TransactionSystem transactionSystem = new();

            BankingFacade bankingFacade = new(accountSystem, loanSystem, transactionSystem);

            bankingFacade.OpenAccountAndApplyForLoan("Savings", "Home Loan");
            bankingFacade.PerformTransaction("Deposit", 5000);
            bankingFacade.CloseAccountAndApproveLoan("Savings", "Home Loan");
        }
    }
}
