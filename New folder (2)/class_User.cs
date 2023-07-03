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