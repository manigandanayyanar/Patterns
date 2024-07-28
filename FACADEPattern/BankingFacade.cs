using FACADEPattern.FACDEClass.BankingClass;

namespace FACADEPattern
{
    public class BankingFacade(AccountSystem accountSystem, LoanSystem loanSystem, TransactionSystem transactionSystem)
    {
        private AccountSystem _accountSystem = accountSystem;
        private LoanSystem _loanSystem = loanSystem;
        private TransactionSystem _transactionSystem = transactionSystem;

        public void OpenAccountAndApplyForLoan(string accountType, string loanType)
        {
            _accountSystem.CreateAccount(accountType);
            _loanSystem.ApplyForLoan(loanType);
        }

        public void CloseAccountAndApproveLoan(string accountType, string loanType)
        {
            _accountSystem.CloseAccount(accountType);
            _loanSystem.ApproveLoan(loanType);
        }

        public void PerformTransaction(string transactionType, double amount)
        {
            _transactionSystem.ProcessTransaction(transactionType, amount);
        }
    }

}
