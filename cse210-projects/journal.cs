
using System;
using System.Collections.Generic;
using System.IO;

namespace Journal
{
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
}