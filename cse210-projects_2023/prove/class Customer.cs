

public class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public List<Account> Accounts { get; set; }

    public Customer(string name, string address, string phoneNumber)
    {
        Name = name;
        Address = address;
        PhoneNumber = phoneNumber;
        Accounts = new List<Account>();
    }

    public void AddAccount(Account account)
    {
        Accounts.Add(account);
    }

    public void RemoveAccount(Account account)
    {
        Accounts.Remove(account);
    }
}