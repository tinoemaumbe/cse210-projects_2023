

  private void WithdrawMoney()
    {
        // This is a derived class that represents an ATM that only allows withdrawals up to a certain limit
public class ATM
{
    private int withdrawalLimit; // The maximum amount that can be withdrawn
}
    // Constructor to initialize the withdrawal limit
    public LimitedATM(int balance, int pin, int withdrawalLimit) : base(balance, pin)
    {
        this.withdrawalLimit = withdrawalLimit;
        // Ask the user how much money to withdraw
        Console.WriteLine("How much money do you want to withdraw?");
        int amount = int.Parse(Console.ReadLine());
    }
        // Check if the amount is valid and there is enough balance
       
        if (amount > 0 && amount <= balance)
        {
            // Deduct the amount from the balance and show a message
            balance -= amount;
            Console.WriteLine($"withdraw sucessful {amount}. Your new balance is {balance}.");
        }
        if (amount > withdrawalLimit)
        {
            Console.WriteLine("Withdrawal limit exceeded. Please enter a smaller amount.");
        }
        else if (amount<= balance)
        {
            Console.WriteLine("Invalid amount or insufficient balance. Please try again.");
        }
    }