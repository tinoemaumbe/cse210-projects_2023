using Ashton;
class ReflectingActivity : BaseActivity
{
    // Attributes
    private List<string> _promptList = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you failed at something."
    };
    private List<string> _promptQuestion = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What was your motivation?"
    };
    private string _prompt;
    private string _question;
    private string _message = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

    // Constructor
    public ReflectingActivity(string activityName, int activityDuration) : base(activityName, activityDuration)
    {
        GetPromptAndQuestions();
    }

    // Method to get the message for the activity
    public void GetActivityMessage()
    {
        Console.WriteLine(_message);
    }

    // Method to get a random prompt from the list
    public void GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_promptList.Count);
        _prompt = _promptList[index];
        Console.WriteLine(_prompt);
    }

    // Method to get a random question from the list
    public void GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_promptQuestion.Count);
        _question = _promptQuestion[index];
        Console.WriteLine(_question);
    }

    // Method to get both prompt and question
    public void GetPromptAndQuestions()
    {
        GetRandomPrompt();
        GetRandomQuestion();
    }
}
