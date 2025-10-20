using System;

public class Word
{
    // ATTRIBUTES
    private bool _state = true;
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
        _state = false;
    }

    // GET METHODS
    public bool GetState()
    {
        return _state;
    }
    public string GetWord()
    {
        return _word;
    }
}