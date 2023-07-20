using System;

public class Menu
{

    private string _menu = $@"
Menu Options:

Please select one of the following options:
1. Create New Goal
2. List Goals
3. Save Goals
4. Load Goals
5. Record Goal Event
6. Quit

Select an option from the menu:  ";

    public string _userInput;
    private int _userChoice = 0;

    
    public int UserChoice()
    
    {
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0;

        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }

    private string _subMenu = $@"
    *SubMenu Options*

    The Types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
    4. Back to Main Menu
    What type of goal would you like to create?  ";

    public string _goalInput;
    private int _goalChoice = 0;

    
    public int GoalChoice()
    
    {

        Console.Write(_menu);

        _goalInput = Console.ReadLine();
        _goalChoice = 0;
        
        try
        {
            _goalChoice = int.Parse(_goalInput);
        }
        catch (FormatException)
        {
            _goalChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _goalChoice;
    }
}
