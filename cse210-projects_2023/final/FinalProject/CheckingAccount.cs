public class CheckingAccount : Account
{
    public decimal OverdraftLimit;
    public decimal MonthlyFee;

    public new decimal AvailableBalance { get; set; }
    public CheckingAccount(int accountNumber, decimal balance, string accountHolderName, decimal overdraftLimit, decimal monthlyFee)
        : base(accountNumber, balance, accountHolderName, null)
    {
        OverdraftLimit = overdraftLimit;
        MonthlyFee = monthlyFee;
    }

    public void DeductMonthlyFee()
    {
        AvailableBalance -= MonthlyFee;
    }
}