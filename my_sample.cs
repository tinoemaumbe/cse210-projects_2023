
using System;
using System.Collections.Generic;
using System.IO;



/*
This program is a daily journal that allows the user to write entries, save them to a file, 
and load them from a file.

*/

//Program class
namespace DailyJournal
{
    class Program
    {
        static List<Entry> journalEntries = new List<Entry>();
        
        //Main method
        //This method is the main method that runs the program
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

        //WriteNewEntry method
        //This method allows the user to write a new entry to the journal
        static void WriteNewEntry()
        {
            Console.WriteLine("Choose a prompt:");
            Console.WriteLine("1. Who was the most interesting person I interacted with today?");
            Console.WriteLine("2. What was the best part of my day?");
            Console.WriteLine("3. How did I see the hand of the Lord in my life today?");
            Console.WriteLine("4. What was the strongest emotion I felt today?");
            Console.WriteLine("5. If I had one thing I could do over today, what would it be?");

            string input = Console.ReadLine();
            int promptChoice;
            if (int.TryParse(input, out promptChoice) && promptChoice >= 1 && promptChoice <= 5)
            {
                Console.WriteLine("Enter your response:");
                string response = Console.ReadLine();
                DateTime date = DateTime.Now;
                Entry entry = new Entry(date, promptChoice, response);
                journalEntries.Add(entry);
                Console.WriteLine("Entry saved");
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        //DisplayJournal method
        //This method displays the journal entries

        static void DisplayJournal()
        {
            foreach (Entry entry in journalEntries)
            {
                Console.WriteLine(entry.ToString());
            }
        }
        //SaveJournal method
        //This method saves the journal entries to a file
        static void SaveJournal()
        {
            Console.WriteLine("Enter filename:");
            string filename = Console.ReadLine();
            try
            {
                using (StreamWriter sw = new StreamWriter(filename))
                {
                    foreach (Entry entry in journalEntries)
                    {
                        sw.WriteLine(entry.ToFileString());
                    }
                }
                Console.WriteLine("Journal saved");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error saving journal: " + ex.Message);
            }
        }

        static void LoadJournal()
        {
            Console.WriteLine("Enter filename:");
            string filename = Console.ReadLine();
            List<Entry> loadedEntries = new List<Entry>();
            try
            {
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                     {
                        loadedEntries.Add(Entry.FromFileString(line));
                    }
                }
                journalEntries = loadedEntries;
                Console.WriteLine("Journal loaded");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error loading journal: " + ex.Message);
            }
        }
   }

    //Entry class
    //This class is the entry class that holds the date, prompt, and response data for each journal entry instance   

    class Entry
    {
        //Entry properties
        public DateTime Date { get; set; }
        public int Prompt { get; set; }
        public string Response { get; set; }

        //Entry constructor
        public Entry(DateTime date, int prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }
        //ToString method
        public override string ToString()
        {
            //Switch case for choosing prompt
            //This switch case chooses the prompt based on the number the user chooses
            string promptString = "";
            switch (Prompt)
            {
                case 1:
                    promptString = "Who was the most interesting person I interacted with today?";
                    break;
                case 2:
                    promptString = "What was the best part of my day?";
                    break;
                case 3:
                    promptString = "How did I see the hand of the Lord in my life today?";
                    break;
                case 4:
                    promptString = "What was the strongest emotion I felt today?";
                    break;
                case 5:
                    promptString = "If I had one thing I could do over today, what would it be?";
                    break;
            }
            return String.Format("{0:d} - {1}\n{2}", Date, promptString, Response);
        }
        //ToFileString method

        public string ToFileString()
        {
            return String.Format("{0:d}|{1}|{2}", Date, Prompt, Response);
        }

        //FromFileString method

        public static Entry FromFileString(string fileString)
        {
            string[] parts = fileString.Split('|');
            DateTime date = DateTime.Parse(parts[0]);
            int prompt = int.Parse(parts[1]);
            string response = parts[2];
            return new Entry(date, prompt, response);
        }
    }
}
















    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine(journal.GetRandomPrompt());
                        string prompt = Console.ReadLine();
                        journal.AddEntry(prompt);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.WriteLine("Enter filename:");
                        string filename = Console.ReadLine();
                        journal.SaveToFile(filename);
                        break;
                    case "4":
                        Console.WriteLine("Enter filename:");
                        filename = Console.ReadLine();
                        journal.LoadFromFile(filename);
                        break;
                    case "5":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }








/*
This program is a daily journal that allows the user to write entries, save them to a file, 
and load them from a file.

*/

//Program class
namespace DailyJournal
{
    class Program
    {
        static List<Entry> journalEntries = new List<Entry>();
        
        //Main method
        //This method is the main method that runs the program
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
}