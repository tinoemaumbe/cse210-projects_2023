namespace Ashton;
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
