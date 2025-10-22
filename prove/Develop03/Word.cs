using System;

public class Word
{
    // ATTRIBUTES
    private string _word = "";

    // CONSTRUCTOR
    public Word(string input)
    {
        _word = input;
    }

    // BEHAVIORS
    public void Hide()
    {
        _word = new string('_', _word.Length);
    }

    public string GetWord()
    {
        return _word;
    }
}