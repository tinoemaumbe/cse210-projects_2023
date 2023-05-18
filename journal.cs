





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

    class Journal
    {
        private List<Entry> entries;
        private List<string> prompts;

        public Journal()
        {
            entries = new List<Entry>();
            prompts = new List<string>()
            {
                "Who was the most interesting person you met today?",
                "What was the best part of your day?",
                "How did you see the hand of the Lord in you life?",
                "What was the strongest emotion you felt today?",
                "If you had one thing you could do today, what would it be?"
            };
        }

        public string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }

        public void AddEntry(string prompt)
        {
            Entry entry = new Entry(prompt);
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (Entry entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (Entry entry in entries)
                {
                    writer.WriteLine(entry.ToString());
                }
            }
        }

        public void LoadFromFile(string filename)
        {
            entries.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Entry entry = new Entry(line);
                    entries.Add(entry);
                }
            }
        }
    }

    class Entry
    {
        private string prompt;
        private string response;
        private DateTime date;

        public Entry(string prompt)
        {
            this.prompt = prompt;
            Console.WriteLine("Please enter response:");
            response = Console.ReadLine();
            date = DateTime.Now;
        }

        public Entry(string line)
        {
            string[] parts = line.Split(',');
            prompt = parts[0];
            response = parts[1];
            date = DateTime.Parse(parts[2]);
        }

        public override string ToString()
        {
            return $"{date}: {prompt} - {response}";
        }
    }
}
