using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int>();
        Console.WriteLine("Enter a series of numbers(Enter 0 to stop):");
        int input = Convert.ToInt32(Console.ReadLine());

        while (input != 0)
        {
            numbers.Add(input);
            input = Convert.ToInt32(Console.ReadLine());
        }

        int Sum = numbers.Sum();
        Console.WriteLine("Sum: " + Sum);

        double Average = numbers.Average();
        Console.WriteLine("Average: " + Average);

        int max = numbers.Max();
        Console.WriteLine("Max: " + max);
    }
}