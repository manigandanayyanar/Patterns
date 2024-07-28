using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADEPattern.FACDEClass.BankingClass
{
    public class AccountSystem
    {
        public void CreateAccount(string accountType)
        {
            Console.WriteLine("Creating account of type: " + accountType);
        }

        public void CloseAccount(string accountType)
        {
            Console.WriteLine("Closing account of type: " + accountType);
        }
    }
}
