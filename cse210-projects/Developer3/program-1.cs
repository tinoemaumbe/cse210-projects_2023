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
    }
}

{
   
    {
        static void Main(string args)
        {
            List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");

            Random rand = new Random();

            int currentScriptureIndex = 0;

            while (true)
            {
                Console.Clear();

                Scripture currentScripture = scriptures[currentScriptureIndex];

                Console.WriteLine(currentScripture.Reference.ToString());
                Console.WriteLine();

                Console.WriteLine(currentScripture.GetRenderedText());

                Console.WriteLine();

                Console.Write("Hide a word (h) or quit (q)? ");

                string input = Console.ReadLine();

                if (input.ToLower() == "h")
                {
                    currentScripture.HideWord(rand);

                    Console.WriteLine();
                    Console.WriteLine(currentScripture.GetRenderedText());
                    Console.WriteLine();
                }
                else if (input.ToLower() == "q")
                {
                    break;
                }

                currentScriptureIndex = (currentScriptureIndex + 1) % scriptures.Count;
            }
        }

        static List<Scripture> LoadScripturesFromFile(string filename)
        {
            List<Scripture> scriptures = new List<Scripture>();

            string lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string parts = line.Split('|');

                if (parts.Length == 5)
                {
                    string book = parts[0];
                    int chapter = int.Parse(parts[1]);
                    int startVerse = int.Parse(parts[2]);
                    int endVerse = int.Parse(parts[3]);
                    string text = parts[4];

                    Reference reference = new Reference(book, chapter, startVerse, endVerse);

                    Scripture scripture = new Scripture(reference, text);

                    scriptures.Add(scripture);
                }
            }

            return scriptures;
        }
    }
}
