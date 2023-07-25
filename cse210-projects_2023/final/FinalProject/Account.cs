public class Account
{
    public int AccNumber { get; set; }
    public decimal Bal{ get; set; }

    public decimal AvailableBalance{ get; set; }
    public string AccountHolderName { get; set; }
    public Customer Customer { get; set; }

    public Account(int Number, decimal availablebal, string accountHolderName, Customer customer)
    {
        AccNumber = Number;
        Bal = availablebal;
        AccountHolderName = accountHolderName;
        Customer = customer;
    }

    public void Deposit(decimal amount)
    {
        AvailableBalance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (AvailableBalance >= amount)
        {
            AvailableBalance -= amount;
        }
        else
        {
            throw new InvalidOperationException("Insufficient funds.");
        }
    }
}