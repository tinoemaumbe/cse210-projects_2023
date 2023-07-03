class Program
{
    // A static method to display the menu options
    static void DisplayMenu()
    {
        Console.WriteLine("Welcome to the Eternal Quest program!");
        Console.WriteLine("Please choose one of the following options:");
        Console.WriteLine("1. Create a new simple goal");
        Console.WriteLine("2. Create a new eternal goal");
        Console.WriteLine("3. Create a new checklist goal");
        Console.WriteLine("4. List all goals");
        Console.WriteLine("5. Save goals and score to a file");
        Console.WriteLine("6. Load goals and score from a file");
        Console.WriteLine("7. Record a goal accomplishment");
        Console.WriteLine("8. Quit the program");
    }
    // A static method to perform the action based on the user's choice
static void PerformAction(int choice, List<Goal> goals, ref int score)
{
    switch (choice)
    {
       // The main method of the program
      DisplayMenu();

            // Get the user's choice and validate it
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            while (choice < 1 || choice > 8)
            {
                Console.Write("Invalid choice. Enter a number between 1 and 8: ");
                choice = int.Parse(Console.ReadLine());
            }

            // Perform different actions based on the user's choice
            switch (choice)
            {
                case 1: // Create a new goal
                    // Get the name and point value of the goal from the user
                    Console.Write("Enter the name of a simple goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the point value of the goal: ");
                    int pointValue = int.Parse(Console.ReadLine());

                    // Create a new goal object with the given name and point value
                    Goal goal = new Goal(name, pointValue);

                    // Add the goal to the user's list of goals
                    user.AddGoal(goal);

                    // Display a confirmation message
                    Console.WriteLine($"Goal {name} created successfully.");
                    break;

                case 2: // Create a new goal
                    // Get the name and point value of the goal from the user
                    Console.Write("Enter the name of an eternal goal goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the point value of the goal: ");
                    int pointValue = int.Parse(Console.ReadLine());

                    // Create a new goal object with the given name and point value
                    Goal goal = new Goal(name, pointValue);

                    // Add the goal to the user's list of goals
                    user.AddGoal(goal);

                    // Display a confirmation message
                    Console.WriteLine($"Goal {name} created successfully.");
                    break;
                case 3: // Create a new goal
                    // Get the name and point value of the goal from the user
                    Console.Write("Enter the name of a checklist goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the point value of the goal: ");
                    int pointValue = int.Parse(Console.ReadLine());

                    // Create a new goal object with the given name and point value
                    Goal goal = new Goal(name, pointValue);

                    // Add the goal to the user's list of goals
                    user.AddGoal(goal);

                    // Display a confirmation message
                    Console.WriteLine($"Goal {name} created successfully.");
                    break;

                case 4: // List all goals
                    // Display the user's information, including the goals and awards
                    user.DisplayInfo();
                    break;
                case 5: // Save goals to a file
                    // Get the file name from the user
                    Console.Write("Enter the file name to save the goals: ");
                    string fileName = Console.ReadLine();

                    // Save the user's goals to the file
                    user.SaveGoals(fileName);
                    break;
                case 6: // Load goals from a file
                    // Get the file name from the user
                    Console.Write("Enter the file name to load the goals: ");
                    fileName = Console.ReadLine();

                    // Load the user's goals from the file
                    user.LoadGoals(fileName);
                    break;
                case 7: // Record a goal completion
                    // Get the name of the goal and the date of completion from the user
                    Console.Write("Enter the name of the goal you completed: ");
                    name = Console.ReadLine();
                    Console.Write("Enter the date of completion (MM/DD/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                case 8: //Quit The Program
                    Console.Write("Thank you participating")
                    break;
}

// The main method of the program
static void Main(string[] args)
{
    // Declare a list of goals and a score variable
    List<Goal> goals = new List<Goal>();
    int score = 0;

    // Declare a boolean variable to control the loop
    bool quit = false;

    // Loop until the user chooses to quit
    while (!quit)
    {
        // Display the menu options
        DisplayMenu();

        // Get the user's choice
        int choice = GetChoice();

        // Perform the action based on the user's choice
        PerformAction(choice, goals, ref score);

        // Check if the user chose to quit
        if (choice == 8)
        {
            quit = true;
        }
    }
}


    {
        // Create a new user with a name
        User user = new User("Tinoe");

      

                    // Find the goal with the given name in the user's list of goals
                    goal = user.Goals.Find(g => g.Name == name);

                    // If the goal is found, record an event and update the points and level accordingly
                    if (goal != null)
                    {
                        user.RecordEvent(goal, date);
                        if (date == DateTime.Today) 
                        {
                            foreach (Goal g in user.Goals) 
                            {
                                if (!g.Completed) 
                                {
                                    TimeSpan remainingTime = g.CompletionDate - date;
                                    if (remainingTime.TotalDays <= 7) 
                                }
                            }