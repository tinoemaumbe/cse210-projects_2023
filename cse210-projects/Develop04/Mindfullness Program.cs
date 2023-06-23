////Mindfulness Program

using Tinoe;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness activity program!");

        for (int i = 5; i > 0; i--)
        {
            Console.WriteLine("*");
            Thread.Sleep(1000);
        }
        
        Menu menu = new Menu();
        menu.DisplayMenu();
        menu.GetUserChoice();

        Console.WriteLine("Thank you for using the activity program!");
    }
}

class Menu
{
    // Attributes
    private List<string> _menu = new List<string>()
    {
        "1. Start breathing activity",
        "2. Start reflecting activity",
        "3. Start listing activity",
        "4. Quit"
    };
    private string _userChoice;

    // Method to display the menu options
    public void DisplayMenu()
    {
        Console.WriteLine("Menu options");
        Console.WriteLine("Please select one of the following options:");
        foreach (string option in _menu)
        {
            Console.WriteLine(option);
        }
    }

    // Method to get user's choice from the menu
    public void GetUserChoice()
    {
        Console.Write("Select an option from the menu: ");
        _userChoice = Console.ReadLine();

        int choice = Int32.Parse(_userChoice);
        if (choice == 1)
        {
            Console.WriteLine("How many seconds do you want to spend in this activity?");
            Console.ReadLine();

            Console.WriteLine("Get Ready..");

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", 10, 5, 5);

            Console.WriteLine("Starting breathing activity...");
            breathingActivity.PrintMessage();
            breathingActivity.BreathIn();
            breathingActivity.BreathOut();
            Console.WriteLine("Breathing activity completed. Press eneter to return to the menu options");
            Console.ReadLine();

            
            while (true)
            {
                DisplayMenu();
                GetUserChoice();
            }
        }
        
         else if (choice == 2)
        {
            Console.WriteLine("Welcome to the Reflecting Activity!");
            Console.WriteLine("How many seconds do you want to do the activity?");
            Console.ReadLine();

            Console.WriteLine("Get Ready..");

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            
            ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", 30);
            reflectingActivity.GetActivityMessage();
            reflectingActivity.GetRandomPrompt();
            reflectingActivity.GetRandomQuestion();

            Thread.Sleep(7000);
            Console.WriteLine("You have completed the Reflecting Activity. Press enter to return to the menu!");
            while (true)
            {
                DisplayMenu();
                GetUserChoice();
            }
        
        }

        else if (choice == 3)
        {
            Console.WriteLine("Welcome to the listing activity!");
            Console.WriteLine("How many seconds to you want to spend in this activity?");
            Console.ReadLine();
            

            Console.WriteLine("Get Ready..");

            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            ListingActivity listingActivity = new ListingActivity("Listing Activity", 30);
            listingActivity.GetMessage();
            Console.WriteLine("List as many responses as you can to the following prompt:");
            listingActivity.GetRandomPrompt();
            Console.Read();

            Console.WriteLine("You have completed the Listing Activity. Press enter to return to the menu!");
            while (true)
            {
                DisplayMenu();
                GetUserChoice();
            }
        
        }

        else{
            Console.WriteLine("You have quited the program");
            
        }
    }
}


using Tinoe;
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

using Tinoe;
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
using Tinoe
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
