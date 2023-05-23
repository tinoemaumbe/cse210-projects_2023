
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


