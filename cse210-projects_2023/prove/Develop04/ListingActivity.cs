using Ashton;
class ListingActivity : BaseActivity
{
    // Attributes
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private string _activityMessage = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    private string _prompt;

    // Constructor
    public ListingActivity(string activityName, int activityDuration) : base(activityName, activityDuration)
    {
        ReturnPrompt();
    }

    // Method to get the message for the activity
    public void GetMessage()
    {
        Console.WriteLine(_activityMessage);
    }

    // Method to get a random prompt from the list
    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        _prompt = _prompts[index];
        Console.WriteLine(_prompt);
    }

    // Method to return prompt
    public string ReturnPrompt()
    {
        GetRandomPrompt();
        return _prompt;
    }
}
