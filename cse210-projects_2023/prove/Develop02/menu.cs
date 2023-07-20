public class Menu
{
    public void Display()
    {
        Console.WriteLine("1. Add new entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Exit");
    }

    public int GetChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
        {
            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
   
        }
        return choice;
    }
}
