
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
// A method to return a string representation of a simple goal
     public override string ToString()
     {
         return $"{(Completed ? "[X]" : "[ ]")} {Name} ({PointValue} points) - Completed {CurrentCount}/{TargetCount} times";
     }
}

