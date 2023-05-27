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
