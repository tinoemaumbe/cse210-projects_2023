// Declare a subclass for a specific type of ATM
class Withdraw : ATM
{
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
}

