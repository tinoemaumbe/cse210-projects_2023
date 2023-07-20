using Ashton;
class BaseActivity
{
    // Attributes
    private string _activityName;
    private int _activityDuration;

    // Constructor
    public BaseActivity(string activityName, int activityDuration)
    {
        _activityName = activityName;
        _activityDuration = activityDuration;
    }

    // Method to get the activity name
    public string GetActivityName()
    {
        return _activityName;
    }

    // Method to get the activity duration
    public int GetActivityDuration()
    {
        return _activityDuration;
    }

    // Method to get ready for the activity
    public void GetReady()
    {
        Console.WriteLine("Getting ready for " + _activityName);
    }

    // Method to indicate that the activity is done
    public void GetDone()
    {
        Console.WriteLine(_activityName + " is done!");
    }

    // Method to count down the time for the activity
    public void CountTime()
    {
        for (int i = _activityDuration; i > 0; i--)
        {
            Console.WriteLine(i + " minutes left...");
            Thread.Sleep(1000 * 60); // Sleep for 1 minute
        }
        Console.WriteLine("Time's up!");
    }
}
