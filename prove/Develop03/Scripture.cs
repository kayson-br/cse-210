using System;

public class Scripture
{
    // ATTRIBUTES
    private int _wordTotal = 0;
    private Reference _reference = new Reference();
    private List<List<Word>> _scripture = new List<List<Word>>();
    private List<Word> _scripturePrint = new List<Word>();
    private List<int> _scriptureShown = new List<int>();

    // CONSTRUCTOR
    public Scripture()
    {
        // _scripture + _wordTotal
        List<string> scripture = new List<string>();
        scripture = _reference.GetScripture();
        for (int verse = 0; verse < scripture.Count(); verse++)
        {
            string[] verseWords = scripture[verse].Split(' ');
            List<Word> wordList = new List<Word>();

            for (int verseWord = 0; verseWord < verseWords.Count(); verseWord++)
            {
                Word word = new Word(verseWords[verseWord]);
                wordList.Add(word);
                _scripturePrint.Add(word);
                _wordTotal++;
            }
            _scripture.Add(wordList);
        }

        // _scriptureShown
        for (int i = 0; i < _wordTotal; i++)
        {
            _scriptureShown.Add(i);
        }
    }

    // BEHAVIORS
    public void Display()
    {
        Console.Clear();
        Console.Write($"\n{_reference.GetReference()}  ");
        for (int word_i = 0; word_i < _scripturePrint.Count(); word_i++)
        {
            Console.Write($"{_scripturePrint[word_i].GetWord()} ");
        }
    }

    public void HideWords()
    {
        Random rand = new Random();

        // Random start
        int scriptureSize = _scriptureShown.Count();

        // Select loop size | Random word hide
        if (scriptureSize > 3)
        {
            for (int i = 0; i < 3; i++)
            {
                int randomIndex = rand.Next(_scriptureShown.Count);
                int randomStart = _scriptureShown[randomIndex];

                _scriptureShown.Remove(randomStart);
                _scripturePrint[randomStart].Hide();
                scriptureSize--;
            }
        }
        else
        {
            for (int i = 0; i < scriptureSize; scriptureSize--)
            {
                int randomIndex = rand.Next(_scriptureShown.Count);
                int randomStart = _scriptureShown[randomIndex];

                _scriptureShown.Remove(randomStart);
                _scripturePrint[randomStart].Hide();
                scriptureSize--;
            }
        }

        Display();
    }
    
    public int ShowSize()
    {
        return _scriptureShown.Count();
    }

}