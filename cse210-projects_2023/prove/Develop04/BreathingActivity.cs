using Ashton;
class BreathingActivity : BaseActivity
{
    // Attributes
    private int _breathIn;
    private int _breathOut;
    private string _message = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    // Constructor
    public BreathingActivity(string activityName, int activityDuration, int breathIn, int breathOut) : base(activityName, activityDuration)
    {
        _breathIn = breathIn;
        _breathOut = breathOut;
    }

    // Method to breathe in
    public void BreathIn()
    {
        Console.WriteLine("Breathe in for " + _breathIn + " seconds...");
        Thread.Sleep(_breathIn * 1000);
    }

    // Method to breathe out
    public void BreathOut()
    {
        Console.WriteLine("Breathe out for " + _breathOut + " seconds...");
        Thread.Sleep(_breathOut * 1000);
    }

    // Method to print out the message for the activity
    public void PrintMessage()
    {
        Console.WriteLine(_message);
    }
}

