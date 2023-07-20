public class Customer
{
    public string Name;
    public string Address;
    public string PhoneNumber;
    public List<Account> Accounts;

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