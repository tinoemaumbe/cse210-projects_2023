public class CheckingAccount : Account
{
    public decimal OverdraftLimit;
    public decimal MonthlyFee;

    public CheckingAccount(int accountNumber, decimal balance, string accountHolderName, decimal overdraftLimit, decimal monthlyFee)
        : base(accountNumber, balance, accountHolderName)
    {
        OverdraftLimit = overdraftLimit;
        MonthlyFee = monthlyFee;
    }

    public void DeductMonthlyFee()
    {
        Balance -= MonthlyFee;
    }
}