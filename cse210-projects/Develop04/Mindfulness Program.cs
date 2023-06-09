using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
{
  {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the activity menu!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    BreathingActivity();
                    break;
                case 2:
                    ReflectionActivity();
                    break;
                case 3:
                    ListingActivity();
                    break;
                case 4:
                    Quit()
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

            Console.ReadLine();
        }

        static void BreathingActivity()
        {
            Console.Clear();
            Console.WriteLine("Breathing Activity");
            Console.WriteLine(" Welcome to breathing activity. This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

            Console.Write("Enter the duration of the activity in seconds: ");
            int duration = int.Parse(Console.ReadLine());

            Console.WriteLine("Prepare to begin...");
            Thread.Sleep(3000);

            for (int i = 0; i < duration; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Breathe in...");
                }
                else
                {
                    Console.WriteLine("Breathe out...");
                }

                Thread.Sleep(1000);
            }

            Console.WriteLine("Good job! You have completed the Breathing Activity for {0} seconds.", duration);
            Thread.Sleep(3000);
        }



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
            

{
    gratitude_activity


        static void Gratitude()
        {
            
            // The standard starting message and prompt for the duration
            Console.WriteLine("Welcome to the gratitude activity!");
            Console.WriteLine("This activity will help you appreciate the good things in your life by having you reflect on some prompts.");
            Console.WriteLine();
            Console.Write("How long do you want to do this activity (in minutes)? ");
            
            int duration = int.Parse(Console.ReadLine());
            
            // Start the timer and display a random prompt
            DateTime startTime = DateTime.Now;
            
            int promptIndex = random.Next(gratitudePrompts.Count);
            string prompt = gratitudePrompts[promptIndex];
            
            Console.WriteLine();
            Console.WriteLine(prompt);
            
            // Remove the prompt from the list so it won't be repeated
            gratitudePrompts.RemoveAt(promptIndex);
            
            // If the list is empty, refill it with all the prompts
            if (gratitudePrompts.Count == 0)
            {
                gratitudePrompts.AddRange(new List<string>()
                {
                    "What are you grateful for today?",
                    "Who are some people that make your life better?",
                    "What is something that made you smile recently?",
                    "What is a positive quality that you have?",
                    "What is something that you enjoy doing?"
                });
            }
            
            // Loop until the duration is reached
            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                // Pause for several seconds before showing another prompt
                Spinner(5);
                
                // Display a random prompt from the list
                promptIndex = random.Next(gratitudePrompts.Count);
                prompt = gratitudePrompts[promptIndex];
                
                Console.WriteLine(prompt);
                
                // Remove the prompt from the list so it won't be repeated
                gratitudePrompts.RemoveAt(promptIndex);
                
                // If the list is empty, refill it with all the prompts
                if (gratitudePrompts.Count == 0)
                {
                    gratitudePrompts.AddRange(new List<string>()
                    {
                        "What are you grateful for today?",
                        "Who are some people that make your life better?",
                        "What is something that made you smile recently?",
                        "What is a positive quality that you have?",
                        "What is something that you enjoy doing?"
                    });
                }
                
                // Check if the duration is reached before showing another prompt
                if ((DateTime.Now - startTime).TotalMinutes >= duration)
                {
                    break;
                }
                
            }
            
            // The standard finishing message for all activities
            Console.WriteLine();
            Console.WriteLine("Thank you for doing the gratitude activity!");
            Console.WriteLine("I hope you feel more grateful and happy.");
            
        }
    }

           }
          }
         }
       } 
     }
    }
  }
}