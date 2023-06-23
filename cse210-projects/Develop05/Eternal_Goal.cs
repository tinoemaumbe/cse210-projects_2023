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
// A method to return a string representation of a eternal goal
     public override string ToString()
     {
         return $"{(Completed ? "[X]" : "[ ]")} {Name} ({PointValue} points) - Completed {CurrentCount}/{TargetCount} times";
     }
}


