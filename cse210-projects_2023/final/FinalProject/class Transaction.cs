public class Transaction
{
    public enum TransactionType { Deposit, Withdrawal, Transfer }

    public TransactionType Type;
    public decimal Amount;
    public int AccountNumber;

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
                account.Balance += Amount;
                break;
            case TransactionType.Withdrawal:
                if (account.Balance >= Amount)
                {
                    account.Balance -= Amount;
                }
                else
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }
                break;
            case TransactionType.Transfer:
                var otherAccount = account.Customer.Accounts.FirstOrDefault(a => a.AccountNumber == AccountNumber);
                if (otherAccount != null)
                {
                    account.Balance -= Amount;
                    otherAccount.Balance += Amount;
                }
                else
                {
                    throw new InvalidOperationException("Invalid account number.");
                }
                break;
        }
    }
}2