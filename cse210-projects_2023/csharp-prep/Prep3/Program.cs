using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int magicNumber = rand.Next(1, 104);

        int guess = 0;
        while (guess != magicNumber)
        {
            Console.Write("Enter your guess");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Guess higher next time");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Guess lower next time");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}