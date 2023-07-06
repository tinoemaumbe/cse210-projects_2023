
    class ATM
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
                Console.WriteLine("1. Check balance");
                Console.WriteLine("2. Withdraw money");
                Console.WriteLine("3. Deposit money");
                Console.WriteLine("4. Change PIN");
                Console.WriteLine("5. Exit");

                // Get the user's choice
                int choice = int.Parse(Console.ReadLine());

                // Perform the corresponding action
                switch (choice)
                {
                    case 1:
                        CheckBalance();
                        break;
                    case 2:
                        WithdrawMoney();
                        break;
                    case 3:
                        DepositMoney();
                        break;
                    case 4:
                        ChangePIN();
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("Thank you for using the ATM. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        public void CheckBalance()
        {
            // Show the current balance
            Console.WriteLine($"Your current balance is {balance}.");
        }

        public void WithdrawMoney()
        {
            // Ask the user how much money to withdraw
            Console.WriteLine("How much money do you want to withdraw?");
            int amount = int.Parse(Console.ReadLine());

            // Check if the amount is valid and there is enough balance
            if (amount > 0 && amount <= balance)
            {
                // Deduct the amount from the balance and show a message
                balance -= amount;
                Console.WriteLine($"You have withdrawn {amount}. Your new balance is {balance}.");
            }
            else
            {
                // Show an error message
                Console.WriteLine("Invalid amount or insufficient balance. Please try again.");
            }
        }

        public void DepositMoney()
        {
            // Ask the user how much money to deposit
            Console.WriteLine("How much money do you want to deposit?");
            int amount = int.Parse(Console.ReadLine());

            // Check if the amount is valid
            if (amount > 0)
            {
                // Add the amount to the balance and show a message
                balance += amount;
                Console.WriteLine($"You have deposited {amount}. Your new balance is {balance}.");
            }
            else
            {
                // Show an error message
                Console.WriteLine("Invalid amount. Please try again.");
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

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the ATM class and run it
            ATM atm = new ATM();
            atm.Run();
        }
    }
