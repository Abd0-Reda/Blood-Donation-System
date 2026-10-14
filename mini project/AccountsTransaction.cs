namespace MiniProjectDepiSimpleBankAccountTeam5
{
    public class AccountsTransaction
    {
        private decimal CurrentBalance;
        public AccountsTransaction(BankCreateAccounts account)
        {
            CurrentBalance = account.Balance;
        }

        public void BalanceCheck()
        {
            Console.WriteLine($"Your balance is: {CurrentBalance}");
        }

        public bool Deposit(decimal amount, List<BankCreateAccounts> accounts, string email)
        {
            try
            {
                if (amount > 150000)
                    throw new ArgumentException("the max of deposit process is $150,000");
                BankCreateAccounts? account = accounts.FirstOrDefault(a => a.Email == email);
                if (account == null) 
                {
                    throw new NullReferenceException("The account is not found");

                }
                CurrentBalance += amount;
                account.Balance = CurrentBalance;
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Withdraw(decimal amount, List<BankCreateAccounts> accounts, string email) 
        {
            try
            {
                if (amount > CurrentBalance)
                    throw new ArgumentException("Withdraw process is invalid please check you have enough money in your account");
                BankCreateAccounts? account = accounts.FirstOrDefault(a => a.Email == email);
                if (account == null)
                {
                    throw new NullReferenceException("The account is not found");

                }
                CurrentBalance -= amount;
                account.Balance = CurrentBalance;
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
