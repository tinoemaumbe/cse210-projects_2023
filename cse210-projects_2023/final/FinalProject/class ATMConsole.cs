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

        Console.WriteLine($"Your current balance is: {account.Balance:C}");

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

        var transaction = new Transaction(Transaction.TransactionType.Withdrawal, amount, account.AccountNumber);
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

        Console.WriteLine($"Your current balance is: {account.Balance:C}");

        var amount = GetDecimalInput("Enter amount to deposit: ");
        if (amount <= 0)
        {
            Console.WriteLine("Invalid amount.");
            return;
        }

        var transaction = new Transaction(Transaction.TransactionType.Deposit, amount, account.AccountNumber);
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

        Console.WriteLine($"Your current balance is: {account.Balance:C}");

        var accountNumber = GetIntegerInput("Enter account number to transfer to: ");
        var otherAccount = customer.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
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

        if (amount > account.Balance)
        {
            Console.WriteLine("Insufficient funds.");
            return;
        }

        var transaction = new Transaction(Transaction.TransactionType.Transfer, amount, accountNumber);
        try
        {
            transaction.Execute(account);
            Console.WriteLine($"Transfer of {amount:C} successful.");
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
            Console.WriteLine("Account notfound.");
            return;
        }

        Console.WriteLine($"Your current balance is: {account.Balance:C}");
    }

    private Customer GetCustomer()
    {
        var customerId = GetIntegerInput("Enter your customer ID: ");
        return atm.Customers.FirstOrDefault(c => c.CustomerId == customerId);
    }

    private Account GetAccount(Customer customer)
    {
        var accountNumber = GetIntegerInput("Enter your account number: ");
        return customer.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber);
    }

    private int GetIntegerInput(string prompt)
    {
        int input;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
    }

    private decimal GetDecimalInput(string prompt)
    {
        decimal input;
        while (true)
        {
            Console.Write(prompt);
            if (decimal.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
            Console.WriteLine("Invalid input. Please enter a decimal number.");
        }
    }
}