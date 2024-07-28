using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADEPattern.FACDEClass.BankingClass
{
    public class TransactionSystem
    {
        public void ProcessTransaction(string transactionType, double amount)
        {
            Console.WriteLine("Processing " + transactionType + " transaction of amount: " + amount);
        }
    }
}
