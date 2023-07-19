using System;

// This is an abstract class that represents an ATM
public abstract class ATM
{
    public int Balance { get; private set; } // The current balance of the account

    // Constructor to initialize the balance and pin
    public ATM(int balance, int pin)
    {
        Balance = balance;
        
    }

    // Abstract method to run the ATM program
    public abstract void Run();

    // Method to check the balance
    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance is {Balance}");
    }

   
// This is a derived class that represents an ATM that only allows deposits
public class DepositATM : ATM
{
    // Constructor to initialize the balance and pin
    public DepositATM(int balance, int pin) : base(balance, pin)
    {
    }

    // Override the Run method to run the deposit program
    public override void Run()
    {
        // Greet the user
        Console.WriteLine("Welcome to the Y.G.T Banking ATM!");

        // Ask the user to enter the PIN
        Console.WriteLine("Please kindly enter your PIN:");
        int inputPin = int.Parse(Console.ReadLine());

        // Check if the PIN is correct
        if (inputPin == PIN)
        {
            // Show the main menu
            ShowMenu();
        }
        else
        {
            // Show an error message and exit
            Console.WriteLine("Wrong PIN. Goodbye!");
            return;
        }
    }

    // Method to show the deposit menu and perform the corresponding action
    public void ShowMenu()
    {
        bool exit = false; // A flag to exit the program

        // Loop until the user chooses to exit
        while (!exit)
        {
            // Show the options
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Exit");

            // Get the user's choice
            int choice = int.Parse(Console.ReadLine());

            // Perform the corresponding action
            switch (choice)
            {
                case 1:
                    DepositMoney();
                    break;
                case 2:
                    exit = true;
                    Console.WriteLine("Thank you for using the ATM. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    // Method to deposit money
    public void DepositMoney()
    {
        // Ask the user how much money to deposit
        Console.WriteLine("How much money do you want to deposit?");
        int amount = int.Parse(Console.ReadLine());

        // Check if the amount is valid
        if (amount > 0)
        {
            // Add the amount to the balance and show a message
            Balance += amount;
            Console.WriteLine($"You have deposited {amount}. Your new balance is {Balance}.");
        }
        else
        {
            // Show an error message
            Console.WriteLine("Invalid amount. Please try again.");
        }
    }
}

// This is the main program
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the DepositATM class
        DepositATM atm = new DepositATM(10000, 1234);

        // Run the ATM program
        atm.Run();
    }
  }
}