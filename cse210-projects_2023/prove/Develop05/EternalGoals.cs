using System;

public class EternalGoal : Goals
{
    private string _goalType = "Eternal Goal:";
    private bool _status;

    public EternalGoal(string type, string name, string description, int points) : base(type, name, description, points)
    {
        _status = false;
    }
    public EternalGoal(string type, string name, string description, int points, bool status) : base(type, name, description, points)
    {
        _status = status;
    }


    public Boolean isCompleted()
    {
        return _status;
    }

    public override void ListGoal(int i)
    {
        if (isCompleted() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetGoalName()} ({GetGoalDescription()})");
        }
        else if (isCompleted() == true)
        {
            Console.WriteLine($"{i}. [X] {GetGoalName()} ({GetGoalDescription()})");
        }
    }
    public override string SaveGoal()
    {
        return ($"{_goalType}; {GetGoalName()}; {GetGoalDescription()}; {GetPoints()}; {_status}");
    }
    public override string LoadGoal()
    {
        return ($"{_goalType}; {GetGoalName()}; {GetGoalDescription()}; {GetPoints()}; {_status}");
    }
    public override void RecordGoalEvent(List<Goals> goals)
    {
       _status = true;
       Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

}