


// Declare a subclass for a specific type of ATM
class BankATM : ATM
{
    // Declare a public constructor that calls the base constructor
    public BankATM(double initialBalance) : base(initialBalance)
    {

    }

    // Override the abstract method for withdrawing mone
    public override void Withdraw(double amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine("You have withdrawn $" + amount + " from Bank ATM");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
        
    }
}

// Declare another subclass for another type of ATM
class StoreATM : ATM
{
    // Declare a public constructor that calls the base constructor
    public StoreATM(double initialBalance) : base(initialBalance)
    {

    }

    // Override the abstract method for withdrawing money
    public override void Withdraw(double amount)
    {
        if (balance >= amount + 2.5) // charge extra fee
        {
            balance -= (amount + 2.5);
            Console.WriteLine("You have withdrawn $" + amount + " from Bank ATM");
            Console.WriteLine("You have been charged $2.5 as service fee");
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
        
    }
}

// Declare a class for testing the program
class Program
{
    static void Main(string[] args)
    {
        // Create an object of BankATM type using the constructor
        ATM atm1 = new BankATM(1000);

        // Call the methods of the BankATM object using the base reference
        atm1.CheckBalance();
        atm1.Deposit(500);
        atm1.Withdraw(200);

        // Create an object of StoreATM type using the constructor
        ATM atm2 = new StoreATM(1000);

        // Call the methods of the StoreATM object using the base reference
        atm2.CheckBalance();
        atm2.Deposit(500);
        atm2.Withdraw(300);
        
    }
}
