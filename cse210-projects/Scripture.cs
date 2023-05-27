
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
