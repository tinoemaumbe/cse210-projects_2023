using System;

public class ChecklistGoal : Goals
{
    private string _goalType = "Check List Goal:";
    private int _numberOfTurns;
    private int _bonusPoints;
    private bool _status;
    private int _count;


    // Constructors
    public ChecklistGoal(string type, string name, string description, int points, int numberTimes, int bonusPoints) : base(type, name, description, points)
    {
        _status = false;
        _numberOfTurns = numberTimes;
        _bonusPoints = bonusPoints;
        _count = 0;
    }
    public ChecklistGoal(string type, string name, string description, int points, bool status, int numberTimes, int bonusPoints, int count) : base(type, name, description, points)
    {
        _status = status;
        _numberOfTurns = numberTimes;
        _bonusPoints = bonusPoints;
        _count = count;
    }

    public int GetTimes()
    {
        return _numberOfTurns;
    }
    public void SetTime()
    {
        _count = _count + 1;
    }
     public int GetCount()
    {
        return _count;
    }
    public void Count()
    {

    }
     public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public Boolean isCompleted()
    {
        return _status;
    }

    // Methods
    public override void ListGoal(int i)
    {
        if (isCompleted() == false)
        {
            Console.WriteLine($"{i}. [ ] {GetGoalName()} ({GetGoalDescription()})  --  is Completed: {GetCount()}/{GetTimes()}");
        }
        else if (isCompleted() == true)
        {
            Console.WriteLine($"{i}. [X] {GetGoalName()} ({GetGoalDescription()})  --  Completed: {GetCount()}/{GetTimes()}");
        }

    }
    public override string SaveGoal()
    {
        return ($"{_goalType}; {GetGoalName()}; {GetGoalDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override string LoadGoal()
    {
        return ($"Simple Goal:; {GetGoalName()}; {GetGoalDescription()}; {GetPoints()}; {_status}; {GetTimes()}; {GetBonusPoints()}; {GetCount()}");
    }
    public override void RecordGoalEvent(List<Goals> goals)
    {
        GetTimes();
        int points = GetPoints();

        if (_count == _numberOfTurns)
        {
            _status = true;
            points = points + _bonusPoints;
  
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
        }
    }

}