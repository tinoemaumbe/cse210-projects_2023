

class ScriptureMemory

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
        Console.WriteLine("Please press enter to hide some words or type 'quit' to exit.");
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
            Console.WriteLine("Please press enter to hide some words or type 'quit' to exit.");
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
            }
        }
    }
