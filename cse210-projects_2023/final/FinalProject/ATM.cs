public class Customer_Class
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Account> Accounts { get; set; }

    public Customer_Class(string name, string address)
    {
        Name = name;
        Address = address;
        Accounts = new List<Account>();
    }
}