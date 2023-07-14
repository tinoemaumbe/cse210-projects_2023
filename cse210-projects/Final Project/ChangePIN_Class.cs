using System;
class ChangePIN:ATM
{
  // Initialize some variables
        int balance = 10000; // The initial balance
        int pin = 1234; // The initial PIN
        bool exit = false; // A flag to exit the program

        public void Run()
        {
            // Greet the user
            Console.WriteLine("Welcome to the Y.G.T Banking ATM!");

            // Ask the user to enter the PIN
            Console.WriteLine("Please kindly enter your PIN:");
            int inputPin = int.Parse(Console.ReadLine());

            // Check if the PIN is correct
            if (inputPin == pin)
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

    
    public void ShowMenu()
    {
            

            // Loop until the user chooses to exit
            while (!exit)
            {
                // Show the options
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("1. Change PIN");
                Console.WriteLine("2. Exit");

                // Get the user's choice
         

                // Perform the corresponding action
                switch (choice)
                {
                    case 1:
                        ChangePIN();
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

  public void ChangePIN()
        {
            // Ask the user to enter the old PIN
            Console.WriteLine("Please enter your old PIN:");
            int oldPin = int.Parse(Console.ReadLine());

            // Check if the old PIN is correct
            if (oldPin == pin)
            {
                // Ask the user to enter the new PIN twice
                Console.WriteLine("Please enter your new PIN:");
                int newPin1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please confirm your new PIN:");
                int newPin2 = int.Parse(Console.ReadLine());

                // Check if the new PINs match and are different from the old PIN
                if (newPin1 == newPin2 && newPin1 != oldPin)
                {
                    // Update the PIN and show a message
                    pin = newPin1;
                    Console.WriteLine("Your PIN has been changed successfully.");
                }
                else
                {
                    // Show an error message
                    Console.WriteLine("The new PINs do not match or are the same as the old PIN. Please try again.");
                }            
                
                
            }
            else
            {
                // Show an error message
                Console.WriteLine("Wrong old PIN. Please try again.");
            }
        }
    }




















    
