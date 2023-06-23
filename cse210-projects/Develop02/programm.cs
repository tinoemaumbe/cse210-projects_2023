class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        var menu = new Menu();

        while (true)
        {
            menu.Display();
            var choice = menu.GetChoice();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter prompt: ");
                    var promptText = Console.ReadLine();
                    Console.Write("Enter response: ");
                    var responseText = Console.ReadLine();
                    var entry = new Entry(promptText, responseText);
                    journal.AddEntry(entry);
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter file name: ");
                    var fileName = Console.ReadLine();
                    journal.SaveToFile(fileName);
                    break;
                case 4:
                    Console.Write("Enter file name: ");
                    fileName = Console.ReadLine();
                    journal.LoadFromFile(fileName);
                    break;
                case 5:
                    return;
            }
        }
    }
}
