public class Prompt
{
    public string _promptText;

    public Prompt(string promptText)
    {
        _promptText = promptText;
    }
}

        public override string ToString()
        {
            //Switch case for choosing prompt
            //This switch case chooses the prompt based on the number the user chooses
            string promptString = "";
            switch (Prompt)
            {
                case 1:
                    promptString = "Who was the most interesting person you met today?";
                    break;
                case 2:
                    promptString = "What was the best part of your day?";
                    break;
                case 3:
                    promptString = "How did you see the hand of the Lord in your life today?";
                    break;
                case 4:
                    promptString = "What was the strongest emotion you felt today?";
                    break;
                case 5:
                    promptString = "If you had one thing you could do over today, what would it be?";
                    break;
            }
            return String.Format("{0:d} - {1}\n{2}", Date, promptString, Response);
        }
    

