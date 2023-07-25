using System.Collections.Generic;
using System.Linq;

public class ATM
{
    public string Location { get; set; }
    public decimal WithdrawLimit { get; set; }
    public List<Customer> Customers { get; set; }

    public ATM()
    {
        // Default constructor
        Customers = new List<Customer>();
    }

    public ATM(string location, decimal withdrawLimit)
    {
        Location = location;
        WithdrawLimit = withdrawLimit;
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