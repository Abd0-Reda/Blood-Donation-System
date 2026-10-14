# Simple Bank Account Management System

A console-based banking application built with **C#** and **.NET 9**. This educational project demonstrates basic object-oriented programming, account registration and login, and simple deposit and withdrawal operations.

## Features

- **Account Registration:** Create an account using a name, email address, and password.
- **Login:** Sign in using an email address and password. The application stops the login process after five failed credential attempts during the current run.
- **Password Validation:** Requires at least 8 characters, an uppercase letter, a lowercase letter, a digit, a special character, and no spaces.
- **Balance Inquiry:** View the current account balance.
- **Deposits:** Deposit funds, with a maximum deposit amount of 150,000 per transaction.
- **Withdrawals:** Withdraw funds when the requested amount does not exceed the current balance.
- **Session Management:** Log out and return to the main menu.

## Project Structure

```text
mini project/
├── AccountsTransaction.cs
├── BankCreateAccounts.cs
├── MiniProjectDepiSimpleBankAccountTeam5.csproj
├── Program.cs
└── README.md
```

- **Program.cs:** Application entry point, sample accounts, registration, login, and interactive console menus.
- **BankCreateAccounts.cs:** Account information, email/password validation, and account-name generation.
- **AccountsTransaction.cs:** Balance inquiry, deposits, and withdrawals.
- **MiniProjectDepiSimpleBankAccountTeam5.csproj:** .NET project configuration.

## Requirements

- .NET 9 SDK
- Visual Studio or Visual Studio Code (optional)

Check your installed SDK:

```bash
dotnet --version
```

## How to Run

1. Open a terminal in the directory containing the `.csproj` file.
2. Run the application:

   ```bash
   dotnet run
   ```

3. Follow the console menu to register, log in, check your balance, deposit, withdraw, or log out.

## Important Notes

- Account data is stored in memory and is reset when the program closes.
- The project contains sample accounts for demonstration purposes.
- This project is for educational purposes only and is not intended for real banking transactions.
- Passwords are not securely hashed, so this implementation is not suitable for production use.
