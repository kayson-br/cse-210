using System;

public class Journal
{
    // DECLARE ATTRIBUTES
    List<Entry> _entries = new List<Entry>();


    // PROGRAM
    public Journal()
    {

    }

    public void ClearEntries()
    {
        List<Entry> entries = new List<Entry>();
        _entries = entries;
    }

    // DECLARE BEHAVIORS
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        Console.WriteLine("");
        foreach (Entry entry in _entries)  // int i = 0; i < _entries.Count; i++
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        // Input Filename
        Console.Write("\nPlease input a file name:\n  > ");
        string filename = Console.ReadLine();

        // Write File
        Console.WriteLine($"Saving entries to {filename}...");
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._promptInput}");
            }
        }
    }

    public void LoadFromFile()
    {
        // Input Filename
        Console.Write("\nPlease input a file name:\n  > ");
        string filename = Console.ReadLine();

        // Create list of entries
        List<Entry> newEntries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Parse journal file to entries list
        Console.WriteLine($"Loading in entries from {filename}...");
        foreach (string line in lines)
        {
            string[] entryAttributes = line.Split("~"); // "entry._date" "entry._prompt" "entry._promptInput"

            Entry entry = new Entry();
            entry._date = entryAttributes[0];
            entry._prompt = entryAttributes[1];
            entry._promptInput = entryAttributes[2];

            newEntries.Add(entry);
        }

        // Send to Journal class entry list
        _entries = newEntries;
    }

}


/*
MAIN
Menu 
1. Write       → Create New Entry Create ENTRY variable function and add to default JOURNAL list
2. Display   → Print all journal entries DISPLAY ENTRIES module (JOURNAL)
3. Load       → Read file, save values into journal entry list LOAD ENTRIES module
4. Save       → Rewrite file with journal entry list Rewrite entries list to file
5. Quit        → End program loop

ENTRY
* _promptInput
* _prompt
* _date
- .UserInput --> Modifies _promptInput
- .Display ENTRY attributes

JOURNAL
* _entries
- .ClearEntries
- .AddEntry(Entry) 
- .DisplayEntries
- .SaveToFile
- .LoadFromFile (replace all entries here) [display last edited date]
*/