
// Declare an abstract class for the ATM
abstract class ATM
{
    // Declare an abstract method for withdrawing money
    public abstract void Withdraw(double amount);

    // Declare a non-abstract method for checking balance
    public void CheckBalance()
    {
        Console.WriteLine("Your balance is $1000");
    }
}

// Declare a subclass for a specific type of ATM
class BankATM : ATM
{
    // Override the abstract method for withdrawing money
    public override void Withdraw(double amount)
    {
        Console.WriteLine("You have withdrawn $" + amount + " from Bank ATM");
    }
}

// Declare another subclass for another type of ATM
class StoreATM : ATM
{
    // Override the abstract method for withdrawing money
    public override void Withdraw(double amount)
    {
        Console.WriteLine("You have withdrawn $" + amount + " from Store ATM");
    }
}

// Declare a class for testing the program
class Program
{
    static void Main(string[] args)
    {
        // Create an object of BankATM type
        ATM atm1 = new BankATM();

        // Call the methods of the BankATM object using the base reference
        atm1.CheckBalance();
        atm1.Withdraw(200);

        // Create an object of StoreATM type
        ATM atm2 = new StoreATM();

        // Call the methods of the StoreATM object using the base reference
        atm2.CheckBalance();
        atm2.Withdraw(300);
    }
}



// Declare an interface for the ATM operations
interface IATMOperations
{
    // Declare methods for depositing, withdrawing, and checking balance
    void Deposit(double amount);
    void Withdraw(double amount);
    double CheckBalance();
}

// Declare a class for the ATM that implements the interface
class ATM : IATMOperations
{
    // Declare a private field for storing the balance
    private double balance;

    // Declare a public constructor that initializes the balance with some value
    public ATM(double initialBalance)
    {
        balance = initialBalance;
    }

    // Implement the interface methods

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("You have deposited $" + amount);
    }

    public void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("You have withdrawn $" + amount);
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
        
    }

    public double CheckBalance()
    {
        return balance;
    }
}
