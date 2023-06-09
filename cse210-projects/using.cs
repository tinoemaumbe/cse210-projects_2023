using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace MindfulnessProgram
{
    class Program
    {
        // A list of activities for the user to choose from
        static List<string> activities = new List<string>()
        {
            "Breathing",
            "Gratitude",
            "Affirmation",
            "Meditation"
        };

        // A list of prompts for the gratitude activity
        static List<string> gratitudePrompts = new List<string>()
        {
            "What are you grateful for today?",
            "Who are some people that make your life better?",
            "What is something that made you smile recently?",
            "What is a positive quality that you have?",
            "What is something that you enjoy doing?"
        };

        // A list of prompts for the affirmation activity
        static List<string> affirmationPrompts = new List<string>()
        {
            "I am worthy of love and respect.",
            "I am capable of achieving my goals.",
            "I am calm and confident.",
            "I am strong and resilient.",
            "I am proud of myself and my accomplishments."
        };

        // A list of prompts for the meditation activity
        static List<string> meditationPrompts = new List<string>()
        {
            "Focus on your breathing and notice how it feels.",
            "Relax your body and release any tension you may have.",
            "Observe your thoughts and feelings without judging them.",
            "Bring your attention to the present moment and what you can sense.",
            "Think of something or someone that makes you happy and feel the emotion."
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

        // A method to display a breathing animation with text
        static void Breathe(string text)
        {
            int length = text.Length;
            
            // Loop through each character in the text
            for (int i = 0; i < length; i++)
            {
                // Display the text up to the current character
                Console.Write(text.Substring(0, i + 1));
                
                // Pause for a short time
                Thread.Sleep(100);
                
                // Clear the text from the console
                Console.SetCursorPosition(Console.CursorLeft - (i + 1), Console.CursorTop);
                Console.Write(new string(' ', i + 1));
                Console.SetCursorPosition(Console.CursorLeft - (i + 1), Console.CursorTop);
                
                // Pause for a longer time at the end of the text
                if (i == length - 1)
                {
                    Thread.Sleep(500);
                }
                
            }
            
            // Loop through each character in reverse order
            for (int i = length - 1; i >= 0; i--)
            {
                // Display the text up to the current character
                Console.Write(text.Substring(0, i + 1));
                
                // Pause for a short time
                Thread.Sleep(100);
                
                // Clear the text from the console
                Console.SetCursorPosition(Console.CursorLeft - (i + 1), Console.CursorTop);
                Console.Write(new string(' ', i + 1));
                Console.SetCursorPosition(Console.CursorLeft - (i + 1), Console.CursorTop);
                
                // Pause for a longer time at the start of the text
                if (i == 0)
                {
                    Thread.Sleep(500);
                }
                
            }
            
        }

        // A method to perform the breathing activity
        static void Breathing()
        {
            
            // The standard starting message and prompt for the duration
            Console.WriteLine("Welcome to the breathing activity!");
            Console.WriteLine("This activity will help you relax and calm your mind by guiding you through some simple breathing exercises.");
            Console.WriteLine();
            Console.Write("How long do you want to do this activity (in minutes)? ");
            
            int duration = int.Parse(Console.ReadLine());
            
            // Start the timer and display instructions
            DateTime startTime = DateTime.Now;
            
            Console.WriteLine();
            Console.WriteLine("Follow the instructions on the screen and breathe in sync with the text.");
            Console.WriteLine();
            
            // Loop until the duration is reached
            while ((DateTime.Now - startTime).TotalMinutes < duration)
            {
                // Display a random instruction
                int instruction = random.Next(1, 5);
                
                switch (instruction)
                {
                    case 1:
                        Console.WriteLine("Breathe in for 4 seconds, hold for 4 seconds, breathe out for 4 seconds.");
                        Breathe("Breathe in");
                        Breathe("Hold");
                        Breathe("Breathe out");
                        break;
                    case 2:
                        Console.WriteLine("Breathe in for 3 seconds, hold for 6 seconds, breathe out for 9 seconds.");
                        Breathe("Breathe in");
                        Breathe("Hold");
                        Breathe("Breathe out");
                        break;
                    case 3:
                        Console.WriteLine("Breathe in for 5 seconds, hold for 2 seconds, breathe out for 7 seconds.");
                        Breathe("Breathe in");
                        Breathe("Hold");
                        Breathe("Breathe out");
                        break;
                    case 4:
                        Console.WriteLine("Breathe in for 6 seconds, hold for 3 seconds, breathe out for 6 seconds.");
                        Breathe("Breathe in");
                        Breathe("Hold");
                        Breathe("Breathe out");
                        break;
                }
                
                // Add some space between instructions
                Console.WriteLine();
                
                // Check if the duration is reached before showing another instruction
                if ((DateTime.Now - startTime).TotalMinutes >= duration)
                {
                    break;
                }
                
            }
            
            // The standard finishing message for all activities
            Console.WriteLine("Thank you for doing the breathing activity!");
            Console.WriteLine("We hope you feel more relaxed and calm.");
            
        }

        // A method to perform the gratitude activity
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
            while ((DateTime.Now - startTime).TotalMinutes < duration)
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
            Console.WriteLine("We hope you feel more grateful and happy.");
            
        }

        // A method to perform the affirmation activity
        static void Affirmation()
        {
            
            // The standard starting message and prompt for the duration
            Console.WriteLine("Welcome to the affirmation activity!");
            Console.WriteLine("This activity will help you boost your self-esteem and confidence by having you)