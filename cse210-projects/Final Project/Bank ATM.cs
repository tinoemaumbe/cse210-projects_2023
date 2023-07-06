using System;
using System.IO;
using System.Globalization;

// Declare a class for testing the program

class Program
{
    static void Main(string[] args)
    {
        // Create an object of ATM type using the constructor
        ATM atm = new ATM("1234567890", 1234, 1000);

        // Prompt the user to enter the card number and pin
        Console.WriteLine("Enter your card number:");
        string cardNumber = Console.ReadLine();
        Console.WriteLine("Enter your pin:");
        int pin = int.Parse(Console.ReadLine());

        // Validate the user input
        if (atm.CardNumber == cardNumber && atm.Pin == pin)
        {
            // Display the menu options
            Console.WriteLine("Welcome to Bank Y.G.T ATM");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");

            // Declare a variable for storing the user choice
            int choice;

            // Repeat until the user chooses to exit
            do
            {
                // Prompt the user to enter the choice
                Console.WriteLine("Enter your choice:");
                choice = int.Parse(Console.ReadLine());

                // Perform different actions based on the choice
                switch (choice)
                {
                    case 1:
                        // Deposit money
                        Console.WriteLine("Enter the amount to deposit:");
                        double depositAmount = double.Parse(Console.ReadLine());
                        atm.Deposit(depositAmount);
                        break;
                    case 2:
                        // Withdraw money
                        Console.WriteLine("Enter the amount to withdraw:");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        atm.Withdraw(withdrawAmount);
                        break;
                    case 3:
                        // Check balance
                        atm.CheckBalance();
                        break;
                    case 4:
                        // Exit
                        Console.WriteLine("Thank you for using our Y.G.T Bank ATM");
                        break;
                    default:
                        // Invalid choice
                        Console.WriteLine("Invalid choice");
                        break;
                }
            } while (choice != 4);
            
        }
        else
        {
            // Invalid card number or pin
            Console.WriteLine("Invalid card number or pin");
        }
        
    }
}

// Declare a class for the ATM
class ATM
{
    // Declare private fields for storing the card number, pin, and balance
    private string cardNumber;
    private int pin;
    private double balance;

    // Declare public properties for accessing the fields
    public string CardNumber
    {
        get { return cardNumber; }
        set { cardNumber = value; }
    }

    public int Pin
    {
        get { return pin; }
        set { pin = value; }
    }

    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }

    // Declare a public constructor that initializes the fields with some values
    public ATM(string cardNumber, int pin, double balance)
    {
        this.CardNumber = cardNumber;
        this.Pin = pin;
        this.Balance = balance;
    }

    // Declare a public method for depositing money
    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine("You have deposited $" + amount);
    }

    // Declare a public method for withdrawing money
    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine("You have withdrawn $" + amount);
        }
        else
        {
            Console.WriteLine("Insufficient funds");
        }
        
    }

    // Declare a public method for checking balance
    public void CheckBalance()
    {
        Console.WriteLine("Your balance is $" + Balance);
    }
}

