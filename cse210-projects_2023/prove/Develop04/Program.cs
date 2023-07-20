using Ashton;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness activity program!");

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine("*");
            Thread.Sleep(1000);
        }
        
        Menu menu = new Menu();
        menu.DisplayMenu();
        menu.GetUserChoice();

        Console.WriteLine("Thank you for using the activity program!");
    }
}
