public class SavingsAccount : Account
{
    public decimal InterestRate;
    public decimal MinimumBalance;

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
}