public class ATM
{
    public string Location;
    public decimal MaxWithdrawalLimit;
    public List<Customer> Customers;

    public ATM(string location, decimal maxWithdrawalLimit)
    {
        Location = location;
        MaxWithdrawalLimit = maxWithdrawalLimit;
        Customers = new List<Customer>();
    }

    public Customer FindCustomerByName(string name)
    {
        return Customers.FirstOrDefault(c => c.Name == name);
    }

    public Customer FindCustomerByAccountNumber(int accountNumber)
    {
        return Customers.FirstOrDefault(c => c.Accounts.Any(a => a.AccountNumber == accountNumber));
    }
}