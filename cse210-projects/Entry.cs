
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
                "How did you see the hand of the Lord in your life?",
                "What was the strongest emotion you felt today?",
                "If you had one thing you could do today, what would it be?"
            };
        
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
