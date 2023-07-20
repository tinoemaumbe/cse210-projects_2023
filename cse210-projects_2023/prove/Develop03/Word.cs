using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public void ShowWord()
    {
        _isHidden = false;
    }

    public string GetRenderedText()
    {
        if (_isHidden)
        {
            return new string('-', _word.Length);
        }
        else
        {
            return _word;
        }
    }
}