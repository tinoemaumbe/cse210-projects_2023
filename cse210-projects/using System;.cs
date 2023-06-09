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