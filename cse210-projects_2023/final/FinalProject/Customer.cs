public class Customer_class
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string PhoneNumber { get; set; }
    public List<Account> newAccount { get; set; }

    public Customer_class(string name, string address, string phoneNumber)
    {
        Name = name;
        Address = address;
        PhoneNumber = phoneNumber;
        newAccount = new List<Account>();
    }

    public void AddAccount(Account account)
    {
        newAccount.Add(account);
    }

    public void RemoveAccount(Account account)
    {
        newAccount.Remove(account);
    }
}