using System;
using System.Threading;


{
    class ProgramMenu
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
    }
}