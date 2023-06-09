using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the activity menu!");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Enumeration Activity");

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
                    EnumerationActivity();
                    break;
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
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

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

        static void ReflectionActivity()
        {
            Console.Clear();
            Console.WriteLine("Reflection Activity");

            // TODO: Implement ReflectionActivity
        }

        static void EnumerationActivity()
        {
            Console.Clear();
            Console.WriteLine("Enumeration Activity");

            // TODO: Implement EnumerationActivity
        }
    }
}
