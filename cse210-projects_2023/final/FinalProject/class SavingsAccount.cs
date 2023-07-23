public class SavingsAccount : Account
{
    public decimal InterestRate { get; set; }
    public decimal MinimumBalance { get; set; }

    public SavingsAccount(int accountNumber, decimal balance, string accountHolderName, decimal interestRate, decimal minimumBalance)
        : base(accountNumber, balance, accountHolderName)
    {
        InterestRate = interestRate;
        MinimumBalance = minimumBalance;
    }

    public decimal CalculateInterest()
    {
        return Balance * InterestRate;
    }

    public new void Withdraw(decimal amount)
    {
        if (Balance - amount < MinimumBalance)
        {
            throw new InvalidOperationException("Withdrawal amount would cause balance to fall below minimum balance.");
        }

        base.Withdraw(amount);
    }
}