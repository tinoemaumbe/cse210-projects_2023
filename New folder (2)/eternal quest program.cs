using System;
using System.Collections.Generic;


class Program
{
    // A static method to display the menu options
    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Eternal Quest program!");
        Console.WriteLine("Please choose one of the following options:");
        Console.WriteLine("1. Create a new simple goal");
        Console.WriteLine("2. Create a new eternal goal");
        Console.WriteLine("3. Create a new checklist goal");
        Console.WriteLine("4. List all goals");
        Console.WriteLine("5. Save goals and score to a file");
        Console.WriteLine("6. Load goals and score from a file");
        Console.WriteLine("7. Record a goal accomplishment");
        Console.WriteLine("8. Quit the program");
    }
    // A static method to perform the action based on the user's choice
static void PerformAction(int choice, List<Goal> goals, ref int score)
{
    switch (choice)
    {
       // The main method of the program
      DisplayMenu();

            // Get the user's choice and validate it
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            while (choice < 1 || choice > 8)
            {
                Console.Write("Invalid choice. Enter a number between 1 and 8: ");
                choice = int.Parse(Console.ReadLine());
            }

            // Perform different actions based on the user's choice
            switch (choice)
            {
                case 1: // Create a new goal
                    // Get the name and point value of the goal from the user
                    Console.Write("Enter the name of a simple goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the point value of the goal: ");
                    int pointValue = int.Parse(Console.ReadLine());

                    // Create a new goal object with the given name and point value
                    Goal goal = new Goal(name, pointValue);

                    // Add the goal to the user's list of goals
                    user.AddGoal(goal);

                    // Display a confirmation message
                    Console.WriteLine($"Goal {name} created successfully.");
                    break;

                case 2: // Create a new goal
                    // Get the name and point value of the goal from the user
                    Console.Write("Enter the name of an eternal goal goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the point value of the goal: ");
                    int pointValue = int.Parse(Console.ReadLine());

                    // Create a new goal object with the given name and point value
                    Goal goal = new Goal(name, pointValue);

                    // Add the goal to the user's list of goals
                    user.AddGoal(goal);

                    // Display a confirmation message
                    Console.WriteLine($"Goal {name} created successfully.");
                    break;
                case 3: // Create a new goal
                    // Get the name and point value of the goal from the user
                    Console.Write("Enter the name of a checklist goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the point value of the goal: ");
                    int pointValue = int.Parse(Console.ReadLine());

                    // Create a new goal object with the given name and point value
                    Goal goal = new Goal(name, pointValue);

                    // Add the goal to the user's list of goals
                    user.AddGoal(goal);

                    // Display a confirmation message
                    Console.WriteLine($"Goal {name} created successfully.");
                    break;

                case 4: // List all goals
                    // Display the user's information, including the goals and awards
                    user.DisplayInfo();
                    break;
                case 5: // Save goals to a file
                    // Get the file name from the user
                    Console.Write("Enter the file name to save the goals: ");
                    string fileName = Console.ReadLine();

                    // Save the user's goals to the file
                    user.SaveGoals(fileName);
                    break;
                case 6: // Load goals from a file
                    // Get the file name from the user
                    Console.Write("Enter the file name to load the goals: ");
                    fileName = Console.ReadLine();

                    // Load the user's goals from the file
                    user.LoadGoals(fileName);
                    break;
                case 7: // Record a goal completion
                    // Get the name of the goal and the date of completion from the user
                    Console.Write("Enter the name of the goal you completed: ");
                    name = Console.ReadLine();
                    Console.Write("Enter the date of completion (MM/DD/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                case 8: //Quit The Program
                    Console.Write("Thank you participating")
                    break;
}

// The main method of the program
static void Main(string[] args)
{
    // Declare a list of goals and a score variable
    List<Goal> goals = new List<Goal>();
    int score = 0;

    // Declare a boolean variable to control the loop
    bool quit = false;

    // Loop until the user chooses to quit
    while (!quit)
    {
        // Display the menu options
        DisplayMenu();

        // Get the user's choice
        int choice = GetChoice();

        // Perform the action based on the user's choice
        PerformAction(choice, goals, ref score);

        // Check if the user chose to quit
        if (choice == 8)
        {
            quit = true;
        }
    }
}


    {
        // Create a new user with a name
        User user = new User("Tinoe");

      

                    // Find the goal with the given name in the user's list of goals
                    goal = user.Goals.Find(g => g.Name == name);

                    // If the goal is found, record an event and update the points and level accordingly
                    if (goal != null)
                    {
                        user.RecordEvent(goal, date);
                        if (date == DateTime.Today) 
                        {
                            foreach (Goal g in user.Goals) 
                            {
                                if (!g.Completed) 
                                {
                                    TimeSpan remainingTime = g.CompletionDate - date;
                                    if (remainingTime.TotalDays <= 7) 
                                }
                            }
                                



abstract class Goal
{
    // Properties of a goal
    public string Name { get; set; } // The name of the goal
    public int PointValue { get; set; } // The point value of the goal
    public bool Completed { get; set; } // Whether the goal is completed or not

    // A constructor to create a new goal with a name and a point value
    public Goal(string name, int pointValue)
    {
        Name = name;
        PointValue = pointValue;
        Completed = false;
    }

    // An abstract method to record an event when the user accomplishes the goal and return the points earned
    public abstract int RecordEvent();

    // A method to return a string representation of a goal
    public override string ToString()
    {
        return $"{(Completed ? "[X]" : "[ ]")} {Name} ({PointValue} points)";
    }
}

// A class to represent a simple goal that can be marked complete and the user gains some value
class SimpleGoal : Goal
{
    // A constructor to create a new simple goal with a name and a point value
    public SimpleGoal(string name, int pointValue) : base(name, pointValue)
    {
    }

    // A method to record an event when the user accomplishes the simple goal and return the points earned
    public override int RecordEvent()
    {
        if (!Completed)
        {
            Completed = true;
            return PointValue;
        }
        else
        {
            return 0;
        }
    }
}

// A class to represent an eternal goal that is never complete, but each time the user records it, they gain some value
class EternalGoal : Goal
{
    // A constructor to create a new eternal goal with a name and a point value
    public EternalGoal(string name, int pointValue) : base(name, pointValue)
    {
    }

    // A method to record an event when the user accomplishes the eternal goal and return the points earned
    public override int RecordEvent()
    {
        return PointValue;
    }
}

// A class to represent a checklist goal that must be accomplished a certain number of times to be complete. Each time the user records this goal they gain some value, but when they achieve the desired amount, they get an extra bonus.
class ChecklistGoal : Goal
{
    // Properties of a checklist goal
    public int TargetCount { get; set; } // The target number of times to accomplish the goal
    public int CurrentCount { get; set; } // The current number of times the goal has been accomplished
    public int BonusValue { get; set; } // The bonus value of completing the goal

    // A constructor to create a new checklist goal with a name, a point value, a target count and a bonus value
    public ChecklistGoal(string name, int pointValue, int targetCount, int bonusValue) : base(name, pointValue)
    {
        TargetCount = targetCount;
        CurrentCount = 0;
        BonusValue = bonusValue;
    }

     // A method to record an event when the user accomplishes the checklist goal and return the points earned
     public override int RecordEvent()
     {
         if (!Completed)
         {
             CurrentCount++;
             if (CurrentCount == TargetCount)
             {
                 Completed = true;
                 return PointValue + BonusValue;
             }
             else
             {
                 return PointValue;
             }
         }
         else
         {
             return 0;
         }
     }

     // A method to return a string representation of a checklist goal
     public override string ToString()
     {
         return $"{(Completed ? "[X]" : "[ ]")} {Name} ({PointValue} points) - Completed {CurrentCount}/{TargetCount} times";
     }
}
// A class to represent a user
class User
{
    // Properties of a user
    public string Name { get; set; } // The name of the user
    public int Score { get; set; } // The score of the user
    public List<Goal> Goals { get; set; } // The list of goals of the user

    // A constructor to create a new user with a name and a score
    public User(string name, int score)
    {
        Name = name;
        Score = score;
        Goals = new List<Goal>();
    }

    // A method to add a new goal to the user's list of goals
    public void AddGoal(Goal goal)
    {
        Goals.Add(goal);
    }

    // A method to save the user's goals and score to a text file
    public void SaveGoals(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            writer.WriteLine(Name);
            writer.WriteLine(Score);
            writer.WriteLine(Goals.Count);
            foreach (Goal goal in Goals)
            {
                writer.WriteLine(goal.GetType().Name); // Write the type of the goal
                writer.WriteLine(goal.Name);
                writer.WriteLine(goal.PointValue);
                writer.WriteLine(goal.Completed);
                if (goal is ChecklistGoal) // If the goal is a checklist goal, write its additional properties
                {
                    ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                    writer.WriteLine(checklistGoal.TargetCount);
                    writer.WriteLine(checklistGoal.CurrentCount);
                    writer.WriteLine(checklistGoal.BonusValue);
                }
            }
        }
        Console.WriteLine($"Goals and score saved to {fileName}");
    }

     // A method to load the user's goals and score from a text file
     public void LoadGoals(string fileName)
     {
         using (StreamReader reader = new StreamReader(fileName))
         {
             Name = reader.ReadLine();
             Score = int.Parse(reader.ReadLine());
             int goalCount = int.Parse(reader.ReadLine());
             Goals.Clear();
             for (int i = 0; i < goalCount; i++)
             {
                 string type = reader.ReadLine(); // Read the type of the goal
                 string name = reader.ReadLine();
                 int pointValue = int.Parse(reader.ReadLine());
                 bool completed = bool.Parse(reader.ReadLine());
                 Goal goal;
                 if (type == "SimpleGoal") // If the goal is a simple goal, create a new simple goal object
                 {
                     goal = new SimpleGoal(name, pointValue);
                 }
                 else if (type == "EternalGoal") // If the goal is an eternal goal, create a new eternal goal object
                 {
                     goal = new EternalGoal(name, pointValue);
                 }
                 else if (type == "ChecklistGoal") // If the goal is a checklist goal, create a new checklist goal object and read its additional properties
                 {
                     int targetCount = int.Parse(reader.ReadLine());
                     int currentCount = int.Parse(reader.ReadLine());
                     int bonusValue = int.Parse(reader.ReadLine());
                     goal = new ChecklistGoal(name, pointValue, targetCount, bonusValue);
                     ((ChecklistGoal)goal).CurrentCount = currentCount;
                 }
                 else // If the type is not recognized, throw an exception
                 {
                     throw new Exception("Invalid goal type");
                 }
                 if (completed) // If the goal is completed, mark it as completed
                 {
                     goal.Completed = true;
                 }
                 Goals.Add(goal); // Add the goal to the list of goals
             }
         }
         Console.WriteLine($"Goals and score loaded from {fileName}");
     }

     // A method to record an event when the user accomplishes a goal and update the score accordingly
     public void RecordEvent(string name)
     {
         // Find the goal with the given name in the user's list of goals
         Goal goal = Goals.Find(g => g.Name == name);

         // If the goal is found, record an event and update the score accordingly
         if (goal != null)
         {
             int pointsEarned = goal.RecordEvent();
             Score += pointsEarned;
             Console.WriteLine($"You accomplished {goal.Name} and earned {pointsEarned} points!");
         }
         else
         {
             Console.WriteLine($"No such goal found: {name}");
         }
     }

     // A method to display the user's information, including the goals and score
     public void DisplayInfo()
     {
         Console.WriteLine($"Name: {Name}");
         Console.WriteLine($"Score: {Score}");
         Console.WriteLine($"Goals: {Goals.Count}");
         foreach (Goal goal in Goals)
         {
             Console.WriteLine(goal);
         }
      }
    }
  