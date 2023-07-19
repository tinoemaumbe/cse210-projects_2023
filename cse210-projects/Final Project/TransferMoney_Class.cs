using System;

// This is an abstract class that represents an ATM
public abstract class ATM
{
    public int Balance { get; protected set; } // The current balance of the account
    public int PIN { get; protected set; } // The PIN of the account

    // Constructor to initialize the balance and pin
    public ATM(int balance, int pin)
    {
        Balance = balance;
        PIN = pin;
    }

    // Abstract method to run the ATM program
    public abstract void Run();

    // Method to check the balance
    public void CheckBalance()
    {
        Console.WriteLine($"Your current balance is {Balance}");
    }

    

// This is a derived class that represents an ATM that allows transfers
public class TransferATM : ATM
{
    // Constructor to initialize the balance and pin
    public TransferATM(int balance, int pin) : base(balance, pin)
    {
    }

    // Override the Run method to run the transfer program
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

    // Method to show the transfer menu and perform the corresponding action
    public void ShowMenu()
    {
        bool exit = false; // A flag to exit the program

        // Loop until the user chooses to exit
        while (!exit)
        {
            // Show the options
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Transfer money");
            Console.WriteLine("2. Exit");

            // Get the user's choice
            int choice = int.Parse(Console.ReadLine());

            // Perform the corresponding action
            switch (choice)
            {
                case 1:
                    TransferMoney();
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

    // Method to transfer money
    public void TransferMoney()
    {
        // Ask the user how much money to transfer
        Console.WriteLine("Please enter the amount of money you want to transfer?");
        int amount = int.Parse(Console.ReadLine());

        // Check if the amount is valid and there is enough balance
        if (amount > 0 && amount <= Balance)
        {
            // Ask the user for the recipient's account number
            Console.WriteLine("Please enter the receiver's account number:");
            int account = int.Parse(Console.ReadLine());

            // Deduct the amount from the balance and show a message
            Balance -= amount;
            Console.WriteLine($"You have transferred {amount} to account {account}. Your new balance is {Balance}.");
        }
        else
        {
            // Show an error message
            Console.WriteLine("Invalid amount or insufficient balance. Please try again.");
        }
    }
}

// This is the main program
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the TransferATM class
        TransferATM atm = new TransferATM(10000, 1234);

        // Run the ATM program
        atm.Run();
    }
  }
}