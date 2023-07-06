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
                        Console.WriteLine("Thank you for using our ATM");
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
