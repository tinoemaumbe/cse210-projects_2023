  
 ListingActivity
{
    class Program
    {
        // A list of prompts for the user to list things
        static List<string> prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        // A random number generator
        static Random random = new Random();

        // A method to display a countdown of several seconds
        static void Countdown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // The standard starting message and prompt for the duration
            Console.WriteLine("Welcome to the listing activity!");
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.WriteLine();
            Console.Write("How long do you want to do this activity (in seconds)? ");
            int duration = int.Parse(Console.ReadLine());

            // Select a random prompt from the list
            int promptIndex = random.Next(prompts.Count);
            string prompt = prompts[promptIndex];

            // Display the prompt and give a countdown of several seconds
            Console.WriteLine();
            Console.WriteLine(prompt);
            Console.WriteLine();
            Console.WriteLine("Get ready to start listing things in...");
            Countdown(5);

            // Start the timer and prompt the user to keep listing items
            DateTime startTime = DateTime.Now;
            Console.WriteLine("Go!");
            
            // A variable to keep track of how many items the user has listed
            int count = 0;

            // Loop until the duration is reached
            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                // Read the user input and increment the count
                string input = Console.ReadLine();
                count++;

                // Check if the duration is reached before prompting for another item
                if ((DateTime.Now - startTime).TotalSeconds >= duration)
                {
                    break;
                }

                // Prompt the user to keep listing items
                Console.Write("Keep going: ");
                
            }

            // Display back the number of items that were entered
            Console.WriteLine();
            Console.WriteLine("You listed " + count + " items!");

            // The standard finishing message for all activities
            Console.WriteLine("Thank you for doing the listing activity!");
            Console.WriteLine("I hope you enjoyed it and learned something valuable.");

         }
       }
    }