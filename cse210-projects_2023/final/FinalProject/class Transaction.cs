public class Transaction
{
    public enum TransactionType { Deposit, Withdrawal, Transfer }

    public TransactionType Type { get; set; }
    public decimal Amount { get; set; }
    public int AccountNumber { get; set; }

    public Transaction(TransactionType type, decimal amount, int accountNumber)
    {
        Type = type;
        Amount = amount;
        AccountNumber = accountNumber;
    }

    public void Execute(Account account)
    {
        switch (Type)
        {
            case TransactionType.Deposit:
                account.Deposit(Amount);
                break;
            case TransactionType.Withdrawal:
                account.Withdraw(Amount);
                break;
            case TransactionType.Transfer:
                var otherAccount = account.Customer.Accounts.FirstOrDefault(a => a.AccountNumber == AccountNumber);
                if (otherAccount != null)
                {
                    account.Withdraw(Amount);
                    otherAccount.Deposit(Amount);
                }
                else
                {
                    throw new InvalidOperationException("Invalid account number.");
                }
                break;
            default:
                throw new InvalidOperationException($"Invalid transaction type: {Type}");
        }
    }
}
