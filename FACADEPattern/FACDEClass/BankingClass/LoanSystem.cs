using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FACADEPattern.FACDEClass.BankingClass
{
    public class LoanSystem
    {
        public void ApplyForLoan(string loanType)
        {
            Console.WriteLine("Applying for loan of type: " + loanType);
        }

        public void ApproveLoan(string loanType)
        {
            Console.WriteLine("Approving loan of type: " + loanType);
        }
    }
}
