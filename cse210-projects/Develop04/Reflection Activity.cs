

 ReflectionActivity
{
    class Program
    {
        // A list of prompts for the user to reflect on
        static List<string> prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        // A list of questions for the user to answer
        static List<string> questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        // A random number generator
        static Random random = new Random();

        // A method to display a spinner while the program is paused
        static void Spinner(int seconds)
        {
            string[] spinner = new string[] { "|", "/", "-", "\\" };
            int index = 0;
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(spinner[index]);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                Thread.Sleep(250);
                index = (index + 1) % spinner.Length;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // The standard starting message and prompt for the duration
            Console.WriteLine("Welcome to the reflection activity!");
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
            Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.WriteLine();
            Console.Write("How long do you want to do this activity (in seconds)? ");
            int duration = int.Parse(Console.ReadLine());
            
            // Select a random prompt from the list
            int promptIndex = random.Next(prompts.Count);
            string prompt = prompts[promptIndex];
            
            // Display the prompt and start the timer
            Console.WriteLine();
            Console.WriteLine(prompt);
            Console.WriteLine();
            
            DateTime startTime = DateTime.Now;
            
            // Loop until the duration is reached
            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                // Select a random question from the list
                int questionIndex = random.Next(questions.Count);
                string question = questions[questionIndex];
                
                // Display the question and pause for several seconds
                Console.WriteLine(question);
                Spinner(15);
                
                // Remove the question from the list so it won't be repeated
                questions.RemoveAt(questionIndex);
                
                // If the list is empty, refill it with all the questions
                if (questions.Count == 0)
                {
                    questions.AddRange(new List<string>()
                    {
                        "Why was this experience meaningful to you?",
                        "Have you ever done anything like this before?",
                        "How did you get started?",
                        "How did you feel when it was complete?",
                        "What made this time different than other times when you were not as successful?",
                        "What is your favorite thing about this experience?",
                        "What could you learn from this experience that applies to other situations?",
                        "What did you learn about yourself through this experience?",
                        "How can you keep this experience in mind in the future?"
                    });
                }
                
                // Add some space between questions
                Console.WriteLine();
                
                // Check if the duration is reached before showing another question
                if ((DateTime.Now - startTime).TotalSeconds >= duration)
                {
                    break;
                }
                
            }
            
            // The standard finishing message for all activities
            Console.WriteLine("Thank you for doing the reflection activity!");
            Console.WriteLine("We hope you enjoyed it and learned something valuable.");
            
         }
    }
}