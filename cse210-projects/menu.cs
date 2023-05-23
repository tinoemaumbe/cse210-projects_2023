namespace DailyJournal
{
    
    Journal menu;
    
        static List<Entry> journalEntries = new List<Entry>();
        
        //Main method
        //This menu is the menu  that shows the program
        //It is a while loop that runs until the user chooses to exit
        //It has a switch statement that allows the user to choose what they want to do
        //It has a try catch statement that catches any errors that may occur
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");

                string input = Console.ReadLine();
                int choice;
                //Switch case for choosing menu options
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            WriteNewEntry();
                            break;
                        case 2:
                            DisplayJournal();
                            break;
                        case 3:
                            SaveJournal();
                            break;
                        case 4:
                            LoadJournal();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Invalid option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
