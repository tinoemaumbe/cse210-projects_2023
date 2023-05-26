using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a new scripture with reference and text
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

        // Create a new game with the scripture
        ScriptureMemoryGame game = new ScriptureMemoryGame(scripture);

        // Play the game
        game.Play();
    }
}

class Scripture
{
    public string Reference { get; private set; }
    public string Text { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public List<string> GetWords()
    {
        // Split the text into individual words
        return new List<string>(Text.Split(' '));
    }
}

class ScriptureWord
{
    public string Word { get; private set; }
    public bool IsHidden { get; set; }

    public ScriptureWord(string word)
    {
        Word = word;
        IsHidden = false;
    }
}

class ScriptureMemoryGame
{
    private readonly List<ScriptureWord> _words;
    private readonly Random _random;

    public ScriptureMemoryGame(Scripture scripture)
    {
        // Split the scripture into individual words and create a list of ScriptureWord objects
        List<string> words = scripture.GetWords();
        _words = new List<ScriptureWord>();
        foreach (string word in words)
        {
            _words.Add(new ScriptureWord(word));
        }

        // Initialize the random number generator
        _random = new Random();
    }

    public void Play()
    {
        // Clear the console screen and display the complete scripture
        Console.Clear();
        Console.WriteLine("Scripture: {0}\n{1}", _words[0].Word, _words[1].Word);
        for (int i = 2; i < _words.Count; i++)
        {
            Console.Write(_words[i].IsHidden ? "____ " : _words[i].Word + " ");
            if (i % 10 == 9) Console.WriteLine();
        }
        Console.WriteLine();

        // Prompt the user to press enter or type quit
        Console.WriteLine("Press enter to hide some words or type 'quit' to exit.");
        string input = Console.ReadLine();
        if (input.ToLower() == "quit") return;

        // Hide some random words and display the scripture again
        HideRandomWords(3);
        Console.Clear();
        Console.WriteLine("Scripture: {0}\n{1}", _words[0].Word, _words[1].Word);
        for (int i = 2; i < _words.Count; i++)
        {
            Console.Write(_words[i].IsHidden ? "____ " : _words[i].Word + " ");
            if (i % 10 == 9) Console.WriteLine();
        }
        Console.WriteLine();

        // Continue prompting the user and hiding more words until all words are hidden
        while (_words.Exists(word => !word.IsHidden))
        {
            Console.WriteLine("Press enter to hide some words or type 'quit' to exit.");
            input = Console.ReadLine();
            if (input.ToLower() == "quit") return;

            HideRandomWords(3);
            Console.Clear();
            Console.WriteLine("Scripture: {0}\n{1}", _words[0].Word, _words[1].Word);
            for (int i = 2; i < _words.Count; i++)
            {
                Console.Write(_words[i].IsHidden ? "____ " : _words[i].Word + " ");
                if (i % 10 == 9) Console.WriteLine();
            }
            Console.WriteLine();
            
            //store scores.
            
            int score=0;
            
            foreach(ScriptureWord word in _words){
                if(word.IsHidden==true){
                    score++;
                }
            }
            
            Console.WriteLine("Your score is "+score+".");
