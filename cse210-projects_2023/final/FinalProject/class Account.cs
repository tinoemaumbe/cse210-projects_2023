public class Account
{
    public int AccountNumber;
    public decimal Balance;
    public string AccountHolderName;

    public Account(int accountNumber, decimal balance, string accountHolderName)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        AccountHolderName = accountHolderName;
    }

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
    }
}