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