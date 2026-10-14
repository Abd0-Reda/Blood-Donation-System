namespace MiniProjectDepiSimpleBankAccountTeam5
{
    internal class Program
    {
        public static List<BankCreateAccounts> accounts = new List<BankCreateAccounts>();
        static void Main(string[] args)
        {
            BankCreateAccounts account1 = new BankCreateAccounts();
            account1.SetEmail("steven@gmail.com");
            account1.SetName("Steven");
            account1.SetPassword("123@PasswordSteven");
            BankCreateAccounts account2 = new BankCreateAccounts();
            account2.SetEmail("Ahmed@gmail.com");
            account2.SetName("Ahmed");
            account2.SetPassword("456@PasswordAhmed");
            BankCreateAccounts account3 = new BankCreateAccounts();
            account3.SetEmail("Reem@gmail.com");
            account3.SetName("Reem");
            account3.SetPassword("789@PasswordReem");

            accounts.Add(account1);
            accounts.Add(account2);
            accounts.Add(account3);

            char ch1;
            Console.WriteLine("\t\tHello in Sherafy Bank");
            Console.WriteLine("\n\t\t=============================\n\n");
            while (true)
            {
                Console.WriteLine("Sign in: (1");
                Console.WriteLine("Log in: (2");
                Console.WriteLine("Exit: (3");
                Console.Write("enter your choice: ");
                ch1 = char.Parse(Console.ReadLine());
                if (ch1 == '1')
                {
                    Regesteration(SignIn());
                }
                else if (ch1 == '2')
                {
                    Login();
                }
                else if (ch1 == '3')
                {
                    Console.WriteLine("thank you to deal with us");
                    break;
                }
                else
                {
                    Console.WriteLine("wrong choice!!!\nPlease try again");
                }
                Console.WriteLine("\t\t\n=============================\n\n");
            }
        }

        public static BankCreateAccounts SignIn()
        {
            BankCreateAccounts account = new BankCreateAccounts();
            Console.Write("Enter your name:");
            string? name = Console.ReadLine();
            if (name == null)
            {
                account.SetName("unKnown");
            }
            else
            {
                account.SetName(name);
            }
            Console.WriteLine("\n--------------------------------\n");

            Console.Write("Enter your email: ");
            string? email = Console.ReadLine();
            while (!account.SetEmail(email))
            {
                Console.Write("Please renter your email again: ");
                email = Console.ReadLine();
            }

            Console.WriteLine("\n--------------------------------\n");

            Console.Write("Enter your Password: ");
            string? pass = Console.ReadLine();
            while (!account.SetPassword(pass))
            {
                Console.Write("Please renter your Password again: ");
                pass = Console.ReadLine();
            }
            accounts.Add(account);
            return account;
        }

        public static void Login()
        {
            string? Email = string.Empty;
            string? Password = string.Empty;
            BankCreateAccounts? account;
            int Tries = 0;
            while (Tries < 5)
            {
                Console.WriteLine("Enter your email: ");
                Console.Write("Email: ");
                Email = Console.ReadLine();
                if (string.IsNullOrEmpty(Email)) 
                {
                    Console.WriteLine("you must enter your email");
                    Console.WriteLine("\n\t\t=============================\n\n");
                    continue;
                }
                Console.WriteLine("Enter your password: ");
                Console.Write("Password: ");
                Password = Console.ReadLine();

                if (string.IsNullOrEmpty(Password))
                {
                    Console.WriteLine("you must enter your password");
                    Console.WriteLine("\n\t\t=============================\n\n");
                    continue;
                }
                account = accounts.FirstOrDefault(x => x.Email == Email);
                if (account == null) 
                {
                    Console.WriteLine("Invalid email or pass\nPlease try again");
                    Console.WriteLine("\n\t\t=============================\n\n");
                    Tries++;
                    continue;
                }

                if (!account.CheckPass(Password))
                {
                    Console.WriteLine("Invalid email or pass\nPlease try again");
                    Console.WriteLine("\n\t\t=============================\n\n");
                    Tries++;
                    continue;
                }
                Regesteration(account);
                return;
            }

            if (Tries >= 5) 
            {
                Console.WriteLine("your account is locked please try again latter");
                return;
            }
        }

        public static void Regesteration(BankCreateAccounts account)
        {
            Console.WriteLine("\t\t\n=============================\n\n");
            Console.WriteLine($"Name account: {account.NameAccount}");
            Console.WriteLine($"Email: {account.Email}");
            Console.WriteLine("\n\t\t=============================\n\n");
            char ch;
            string ch2;
            decimal amount;
            AccountsTransaction transaction = new AccountsTransaction(account);
            while (true)
            {
                Console.WriteLine("1)Get Balance.\t\t2)Deposite.\t\t3)Withdraw.\t\t4)Log out.");
                Console.Write("Your choice: ");
                ch = char.Parse(Console.ReadLine());
                if (ch == '1')
                {
                    transaction.BalanceCheck();
                }
                else if (ch == '2')
                {
                    Console.Write("Enter the amount to deposite: ");
                    amount = Convert.ToDecimal(Console.ReadLine());
                    while (!transaction.Deposit(amount,accounts,account.Email))
                    {
                        Console.Write("Are you want to exit? y) n) ");
                        ch2 = Console.ReadLine();
                        if (ch2.ToUpper() == "Y" || ch2.ToUpper() == "YES")
                            break;
                        Console.Write("Enter the amount again: ");
                        amount = Convert.ToDecimal(Console.ReadLine());
                    }
                    Console.WriteLine("The transaction is success!!");
                }
                else if(ch == '3')
                {
                    Console.Write("Enter the amount to withdraw: ");
                    amount = Convert.ToDecimal(Console.ReadLine());
                    while (!transaction.Withdraw(amount, accounts, account.Email))
                    {
                        Console.Write("Are you want to exit? y) n)");
                        ch2 = Console.ReadLine();
                        if (ch2.ToUpper() == "Y" || ch2.ToUpper() == "YES")
                            break;
                        Console.Write("Enter the amount again: ");
                        amount = Convert.ToDecimal(Console.ReadLine());
                    }
                    Console.WriteLine("The transaction is success!!");
                    
                }
                else if (ch == '4')
                {
                    Console.WriteLine("You are log out see you soon :)");
                    Console.WriteLine("\n\t\t=============================\n\n");
                    break;
                }
                else
                {
                    Console.WriteLine("wrong choice!!!\nPlease try again");
                }
                Console.WriteLine("\n\t\t=============================\n\n");
            }
        }
    }
}
