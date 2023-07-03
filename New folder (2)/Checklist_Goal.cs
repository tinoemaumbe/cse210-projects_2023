class ChecklistGoal
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