namespace MiniProjectDepiSimpleBankAccountTeam5
{
    public class BankCreateAccounts
    {
        private string pass = "";
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string NameAccount { get; private set; } = string.Empty;
        public decimal Balance { get; set; }

        public BankCreateAccounts()
        {
            Balance = -0.5m;
        }

        public void SetName(string name)
        {
            this.Name = name;
            Random rand = new Random();
            NameAccount = name + rand.Next(100, 999).ToString();
        }


        public bool SetEmail(string email)
        {
            try
            {
                if (email.Contains("@"))
                {
                    Email = email;
                    return true;
                }
                throw new ArgumentException("the email must be contain @ sign please try again");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool SetPassword(string password)
        {
            try
            {
                pass = password;
                string PassRules = "";
                bool isContainValid = true;

                PassRules = "";
                if (pass.Count() < 8)
                {
                    PassRules += "Password must be at least 8 characters long.\n";
                    isContainValid = false;
                }
                if (!pass.Any(char.IsUpper))
                {
                    PassRules += "Password must contain at least one uppercase letter.\n";
                    isContainValid = false;
                }
                if (!pass.Any(char.IsLower))
                {
                    PassRules += "Password must contain at least one lowercase letter.\n";
                    isContainValid = false;
                }
                if (!pass.Any(char.IsDigit))
                {
                    PassRules += "Password must contain at least one digit.\n";
                    isContainValid = false;
                }
                if (!pass.Any(ch => !char.IsLetterOrDigit(ch)))
                {
                    PassRules += "Password must contain at least one special character.\n";
                    isContainValid = false;
                }
                if (pass.Contains(' '))
                {
                    PassRules += "Password must not contain spaces.\n";
                    isContainValid = false;
                }

                if (!isContainValid)
                {
                    throw new ArgumentException(PassRules);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool CheckPass(string pass)
        {
            return this.pass == pass;
        }
    }
}
