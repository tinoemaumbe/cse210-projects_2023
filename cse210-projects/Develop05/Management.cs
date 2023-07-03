using System;
using System.IO;

public class Management

{
    // Attributes
    private List<Goals> _goals = new List<Goals>();
    private int _totalPoints;


    // Constructors
    public Management()
    {
        _totalPoints = 0;
    }
    public void AddGoal(Goals goal)
    {
        _goals.Add(goal);
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public void AddBonus(int bonusPoints)
    {
        _totalPoints += bonusPoints;
    }
    public void SetTotalPoints(int totalPoints)
    {
        _totalPoints = totalPoints;
    }
    public List<Goals> GetGoalsList()
    {
        return _goals;
    }

    public void ListGoals()
    {
        if (_goals.Count() > 0)
        {
            Console.WriteLine("\nNote that your Goals are:");

            int index = 1;
            foreach (Goals goal in _goals)
            {
                goal.ListGoal(index);
                index = index + 1;
            }
        }
        else
        {
            Console.WriteLine("\nYou currently have no goals!");
        }
    }
    public void RecordGoalEvent()
    {
        ListGoals();

        Console.Write("\nName the goal you accomplished?  ");
        int select = int.Parse(Console.ReadLine())-1;

        int goalPoints = GetGoalsList()[select].GetPoints();
        AddPoints(goalPoints);

        GetGoalsList()[select].RecordGoalEvent(_goals);

        Console.WriteLine($"\n*** You have {GetTotalPoints()} points! ***\n");
    }
    public void SaveGoals()
    {
        Console.Write("\nEnter the name of your goal file  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            // Save Total Points
            outputFile.WriteLine(GetTotalPoints());
            // Save goals list
            foreach (Goals goal in _goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("\nEnter the name of your goal file.  ");
        string userInput = Console.ReadLine();
        string userFileName = userInput + ".txt";

        if (File.Exists(userFileName))
        {
            string[] readText = File.ReadAllLines(userFileName);

            int totalPoints = int.Parse(readText[0]);
            SetTotalPoints(totalPoints);
            readText = readText.Skip(1).ToArray();
            
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                string type = entries[0];
                string name = entries[1];
                string description = entries[2];
                int points = int.Parse(entries[3]);
                bool status = Convert.ToBoolean(entries[4]);

                if (entries[0] == "Simple Goal:")
                {
                    SimpleGoal sGoal = new SimpleGoal(type, name, description, points, status);
                    AddGoal(sGoal);
                }
                if (entries[0] == "Eternal Goal:")
                {
                    EternalGoal eGoal = new EternalGoal(type, name, description, points, status);
                    AddGoal(eGoal);
                }
                if (entries[0] == "Check List Goal:")
                {
                    int numberTimes = int.Parse(entries[5]);
                    int bonusPoints = int.Parse(entries[6]);
                    int counter = int.Parse(entries[7]);
                    ChecklistGoal clGoal = new ChecklistGoal(type, name, description, points, status, numberTimes, bonusPoints, counter);
                    AddGoal(clGoal);
                }
                
            }
        }
    }


}