using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {

        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        Management goals = new Management();

        Console.Clear();
        Console.Write("Welcome to the Eternal Quest Program");

        Console.Write($"\nYou currently have {goals.GetTotalPoints()} points!\n");
        Menu choice = new Menu();
        Menu goalChoice = new Menu();


        int action = 0;
        while (action != 6)
        // switch case for menu
        {
            action = choice.UserChoice();
            switch (action)
            {
                case 1:
                    Console.Clear();  
                    int goalInput = 0;
                    while (goalInput != 5)
                    {
                        goalInput = goalChoice.UserChoice();
                        switch (goalInput)
                        {
                            case 1:
                                // Simple Goal
                                Console.WriteLine("Name your goal?  ");
                                string name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                string description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                int points = int.Parse(Console.ReadLine());
                                SimpleGoal sGoal = new SimpleGoal("Simple Goal:", name, description, points);
                                goals.AddGoal(sGoal);
                                goalInput = 5;
                                break;
                            case 2:
                                // Eternal Goal
                                Console.WriteLine("Name your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                EternalGoal eGoal = new EternalGoal("Eternal Goal:", name, description, points);
                                goals.AddGoal(eGoal);
                                goalInput = 5;
                                break;
                            case 3:
                                // Checklist Goal
                                Console.WriteLine("Name your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("What is the amount of points associated with this goal?  ");
                                points = int.Parse(Console.ReadLine());
                                Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
                                int numberTimes = int.Parse(Console.ReadLine());
                                Console.Write("What is the bonus for accomplishing it that many times?  ");
                                int bonusPoints = int.Parse(Console.ReadLine());
                                ChecklistGoal clGoal = new ChecklistGoal("Check List Goal:", name, description, points, numberTimes, bonusPoints);
                                goals.AddGoal(clGoal);
                                goalInput = 5;
                                break;
                            case 4:
                                // Negative Goal
                                Console.WriteLine("Name your goal?  ");
                                name = Console.ReadLine();
                                name = textInfo.ToTitleCase(name);
                                Console.WriteLine("What is a short description of your goal?  ");
                                description = Console.ReadLine();
                                description = textInfo.ToTitleCase(description);
                                Console.Write("How many points should be subtracted for not meeting this goal?  ");
                                points = int.Parse(Console.ReadLine());
                               
                                break;
                            case 5:
                                // Exit
                                break;
                            default:
                                Console.WriteLine($"\nSorry, You have entered an invalid option.");
                                break;
                        }
                    }
                    break;
                case 2:
                    // List Goals
                    Console.Clear();
                    Console.Write($"\nYou currently have {goals.GetTotalPoints()} points!\n");
                    goals.ListGoals();
                    break;
                case 3:
                    // Save Goals
                    goals.SaveGoals();
                    break;
                case 4:
                    // Load Goals
                    Console.Clear();  
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.LoadGoals();
                    break;
                case 5:
                    // Record Event
                    Console.Clear();  
                    Console.Write($"\n*** You currently have {goals.GetTotalPoints()} points! ***\n");
                    goals.RecordGoalEvent();
                    break;
                case 6:
                    // Quite
                    Console.WriteLine("\nThank you for using the Eternal Quest Program! CaLL again!!!\n");
                    break;
                default:
                    Console.WriteLine($"\nYou have entered an invalid option\n.");
                    break;
            }
        }
    }
}