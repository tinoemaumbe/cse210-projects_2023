
class Program
{
    static void Main(string[] args)
    {
        var atm = new ATM();
        var console = new ATMConsole(atm);
        console.Run();
    }
}