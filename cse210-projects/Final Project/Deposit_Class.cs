

class Deposit : ATM

{

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
    }