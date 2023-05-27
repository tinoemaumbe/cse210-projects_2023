public class Scripture
{
    private Reference _reference;
    private bool _isCompletelyHidden;
    private List<Word> _words;

    public Scripture(string text, Reference reference)
    {
        _reference = reference;
        _isCompletelyHidden = false;
        CreateWordList(text);
    }

    public void CreateWordList(string text)
    {
        // Split the text into words and create a Word object for each.
        string words = text.Split(' ');
        _words = new List<Word>();
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideWords()
    {
        // Hide a random word if not all words are hidden yet.
        if (!_isCompletelyHidden)
        {
            Random random = new Random();
            int index = random.Next(_words.Count);
            _words[index].HideWord();
            if (_words.All(w => w.GetRenderedText() == new string('-', w.GetRenderedText().Length)))
            {
                _isCompletelyHidden = true;
            }
        }
    }

    public string GetRenderedText(string type)
    {
        if (type == "hidden")
        {
            // Return the scripture text with hidden words.
            string renderedWords = _words.Select(w => w.GetRenderedText()).ToArray();
            return string.Join(" ", renderedWords);
        }
        else
        {
            // Return the scripture text with all words visible.
            string visibleWords = _words.Select(w => w.GetRenderedText().Replace('-', w.ToString())).ToArray();
            return string.Join(" ", visibleWords);
        }
    }
}