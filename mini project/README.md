Simple Bank Account Management System
A console-based banking application built with C# and .NET 9. This educational mini project demonstrates basic object-oriented programming, account registration and login, and simple deposit and withdrawal operations.
Features
- Account registration: Create an account using a name, email address, and password.
- Login: Sign in using an email address and password. The application stops the login process after five failed credential attempts during the current run.
- Password validation: Requires at least 8 characters, an uppercase letter, a lowercase letter, a digit, a special character, and no spaces.
- Balance inquiry: View the current account balance.
- Deposits: Deposit funds, with a maximum deposit amount of 150,000 per transaction.
- Withdrawals: Withdraw funds when the requested amount does not exceed the current balance.
- Session management: Log out and return to the main menu.
Project Structure
mini project/
├── AccountsTransaction.cs
├── BankCreateAccounts.cs
├── MiniProjectDepiSimpleBankAccountTeam5.csproj
├── Program.cs
└── README.md
- Program.cs — Application entry point, sample accounts, registration, login, and interactive console menus.
- BankCreateAccounts.cs — Account information, email/password validation, and account-name generation.
- AccountsTransaction.cs — Balance inquiry, deposits, and withdrawals.
- MiniProjectDepiSimpleBankAccountTeam5.csproj — .NET project configuration.
Requirements
- .NET 9 SDK
- A terminal or an IDE such as Visual Studio or Visual Studio Code
Verify your installed .NET SDK:
dotnet --version
How to Run
1. Open a terminal in the directory containing MiniProjectDepiSimpleBankAccountTeam5.csproj.
2. Run the application:
   dotnet run
3. Follow the console menu to register an account, log in, check the balance, deposit funds, withdraw funds, or log out.
Important Notes
- Account data is stored in memory, so newly created accounts and balances are reset when the application closes.
- The source includes sample accounts for demonstration purposes. Avoid using real or sensitive passwords with this project.
- This is an educational prototype, not production-ready banking software. It does not use persistent storage, secure password hashing, or real financial transactions.
