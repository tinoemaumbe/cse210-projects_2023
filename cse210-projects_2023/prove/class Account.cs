public class Account
{
    public int AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public string AccountHolderName { get; set; }
    public Customer Customer { get; set; }

    public Account(int accountNumber, decimal balance, string accountHolderName, Customer customer)
    {
        AccountNumber = accountNumber;
        Balance = balance;
        AccountHolderName = accountHolderName;
        Customer = customer;
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