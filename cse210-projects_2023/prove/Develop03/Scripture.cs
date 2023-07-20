using System;

class Scripture
{
    private string reference;
    private string text;
    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this._words = new List<Word>(_words.Split(' '));
    }

    public void HideWords()
    {
        Random rand = new Random();
        int numWordsToHide = rand.Next(1, _words.Count / 2);

        for (int i = 0; i < numWordsToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].HideWord();
        }
    }

    public override string ToString()
    {
        return $"{reference}: {string.Join(' ', _words)}";
    }
}
