using System;
using System.Collections.Generic;

public class Reference
{
    private List<string> _scripture = new List<string>();
    private string _reference = "";

    public Reference()
    {
        Random rand = new Random();

        // SCRIPTURE LIST
        // D&C 4
        List<string> DC_4 = new List<string>
        {
            "Now behold, a marvelous work is about to come forth among the children of men.",
            "Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind and strength, that ye may stand blameless before God at the last day.",
            "Therefore, if ye have desires to serve God ye are called to the work;",
            "For behold the field is white already to harvest; and lo, he that thrusteth in his sickle with his might, the same layeth up in store that he perisheth not, but bringeth salvation to his soul;",
            "And faith, hope, charity and love, with an eye single to the glory of God, qualify him for the work.",
            "Remember faith, virtue, knowledge, temperance, patience, brotherly kindness, godliness, charity, humility, diligence.",
            "Ask, and ye shall receive; knock, and it shall be opened unto you. Amen."
        };
        // Proverbs 3
        List<string> Proverbs_3 = new List<string>
        {
            "My son, forget not my law; but let thine heart keep my commandments.",
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding.",
            "In all thy ways acknowledge him, and he shall direct thy paths."
        };

        // Random Reference Chapter
        List<List<string>> references = new List<List<string>> { DC_4, Proverbs_3 };
        int chapterIndex = rand.Next(references.Count);
        List<string> chapter = references[chapterIndex];

        // Random Reference Verses
        int startIndex = rand.Next(chapter.Count);      // random --> 0-based index of chapter
        int maxVerses = chapter.Count - startIndex;     // 7(maxNum) - 6(maxIndex) = 1 verse
        int verseCount = rand.Next(1, maxVerses + 1);   // at least 1 verse

        // _scripture
        for (int i = 0; i < verseCount; i++)
        {
            _scripture.Add(chapter[startIndex + i]);
        }

        // _reference chapter
        List<string> referenceNames = new List<string> { "Doctrine & Covenants 4", "Proverbs 3" };
        _reference = referenceNames[chapterIndex];
        // _reference verses
        if (verseCount == 1)
        {
            _reference += ":" + (startIndex + 1);
        }
        else
        {
            _reference += ":" + (startIndex + 1) + "-" + (startIndex + verseCount);
        }
    }

    public List<string> GetScripture()
    {
        return _scripture;
    }
    
    public string GetReference()
    {
        return _reference;
    }

}