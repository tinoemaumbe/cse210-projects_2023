using System;
using System.Linq;

public class ATMConsole
{
    private readonly ATM atm;

    public ATMConsole(ATM atm)
    {
        this.atm = atm;
    }

    public void Run()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the ATM");
            Console.WriteLine("==================");
            Console.WriteLine("1. Withdraw money");
            Console.WriteLine("2. Deposit money");
            Console.WriteLine("3. Transfer money");
            Console.WriteLine("4. Check balance");
            Console.WriteLine("5. Exit");

            var choice = GetIntegerInput("Enter your choice: ");

            switch (choice)
            {
                case 1:
                    WithdrawMoney();
                    break;
                case 2:
                    DepositMoney();
                    break;
                case 3:
                    TransferMoney();
                    break;
                case 4:
                    CheckBalance();
                    break;
                case 5:
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }

    private void WithdrawMoney()
    {
        Console.Clear();
        Console.WriteLine("Withdraw Money");
        Console.WriteLine("===============");

        var customer = GetCustomer();
        if (customer == null)
        {
            Console.WriteLine("Customer not found.");
            return;
        }

        var account = GetAccount(customer);
        if (account == null)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        Console.WriteLine($"Your current balance is: {account.AvailableBalance:C}");

        var amount = GetDecimalInput("Enter amount to withdraw: ");
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        if (amount > atm.MaxWithdrawalLimit)
        {
            Console.WriteLine($"Withdrawal limit exceeded. Maximum withdrawal amount is {atm.MaxWithdrawalLimit:C}");
            return;
        }

        var transaction = new Transaction(TransactionType.Withdrawal, amount, account.AccNumber);
        try
        {
            transaction.Execute(account);
            Console.WriteLine($"Withdrawal of {amount:C} successful.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private void DepositMoney()
    {
        Console.Clear();
        Console.WriteLine("Deposit Money");
        Console.WriteLine("==============" );

        var customer = GetCustomer();
        if (customer == null)
        {
            Console.WriteLine("Customer not found.");
            return;
        }

        var account = GetAccount(customer);
        if (account == null)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        Console.WriteLine($"Your current balance is: {account.AvailableBalance:C}");

        var amount = GetDecimalInput("Enter amount to deposit: ");
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        var transaction = new Transaction(TransactionType.Deposit, amount, account.AccNumber);
        transaction.Execute(account);
        Console.WriteLine($"Deposit of {amount:C} successful.");
    }

    private void TransferMoney()
    {
        Console.Clear();
        Console.WriteLine("Transfer Money");
        Console.WriteLine("==============");

        var customer = GetCustomer();
        if (customer == null)
        {
            Console.WriteLine("Customer not found.");
            return;
        }

        var account = GetAccount(customer);
        if (account == null)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        Console.WriteLine($"Your current balance is: {account.AvailableBalance:C}");

        var accountNumber = GetIntegerInput("Enter account number to transfer to: ");
        var otherAccount = customer.Accounts.FirstOrDefault(a => a.AccNumber == accountNumber);
        if (otherAccount == null)
        {
            Console.WriteLine("Invalid account number.");
            return;
        }

       var amount = GetDecimalInput("Enter amount to transfer: ");
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        var transaction = new Transaction(TransactionType.Transfer, amount, account.AccNumber, otherAccount.AccNumber);
        try
        {
            transaction.Execute(account, otherAccount);
            Console.WriteLine($"Transfer of {amount:C} to account {otherAccount.AccNumber} successful.");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private void CheckBalance()
    {
        Console.Clear();
        Console.WriteLine("Check Balance");
        Console.WriteLine("=============");

        var customer = GetCustomer();
        if (customer == null)
        {
            Console.WriteLine("Customer not found.");
            return;
        }

        var account = GetAccount(customer);
        if (account == null)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        Console.WriteLine($"Your current balance is: {account.AvailableBalance:C}");
    }

    private Customer GetCustomer()
    {
        var customerId = GetIntegerInput("Enter customer ID: ");
        return atm.Customers.FirstOrDefault(c => c.CustomerId == customerId);
    }

    private Account GetAccount(Customer customer)
    {
        var accountNumber = GetIntegerInput("Enter account number: ");
        return customer.Accounts.FirstOrDefault(a => a.AccNumber == accountNumber);
    }

    private int GetIntegerInput(string message)
    {
        Console.Write(message);
        int input;
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.Write(message);
        }
        return input;
    }

    private decimal GetDecimalInput(string message)
    {
        Console.Write(message);
        decimal input;
        while (!decimal.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            Console.Write(message);
        }
        return input;
    }
}

public class ATM
{
    public decimal MaxWithdrawalLimit { get; set; } // Define the MaxWithdrawalLimit property

    public List<Customer> Customers { get; } = new List<Customer>();
}

public class Customer
{
    public int CustomerId { get; set; } // Define the CustomerId property

    public List<Account> Accounts { get; } = new List<Account>();
}

public class Account_Class
{
    public int AccountNumber { get; set; }

    public decimal Balance { get; set; }
}

public enum TransactionType
{
    Withdrawal,
    Deposit,
    Transfer
}

public class Transaction
{
    public TransactionType Type { get; }

    public decimal Amount { get; }

    public int SourceAccountNumber { get; }

    public int? DestinationAccountNumber { get; }

    public Transaction(TransactionType type, decimal amount, int sourceAccountNumber, int? destinationAccountNumber = null)
    {
        Type = type;
        Amount = amount;
        SourceAccountNumber = sourceAccountNumber;
        DestinationAccountNumber = destinationAccountNumber;
    }

    public void Execute(Account sourceAccount, Account destinationAccount = null)
    {
        switch (Type)
        {
            case TransactionType.Withdrawal:
                if (sourceAccount.AvailableBalance < Amount)
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }
                sourceAccount.AvailableBalance -= Amount;
                break;
            case TransactionType.Deposit:
                sourceAccount.AvailableBalance += Amount;
                break;
            case TransactionType.Transfer:
                if (sourceAccount.AvailableBalance < Amount)
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }
                sourceAccount.AvailableBalance -= Amount;
                destinationAccount.AvailableBalance += Amount;
                break;
        }
    }
}