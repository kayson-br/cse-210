
using System;

public class Entry
{
    // DECLARE ATTRIBUTE
    public string _prompt;
    public string _promptInput;
    public string _date;


    // PROGRAM
    public Entry()
    {
        // MODIFY _prompt
        List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "If you could do anything you wanted right now, what would it be?"
        };
        Random random = new Random();
        int r = random.Next(prompts.Count);
        _prompt = prompts[r];

        // MODIFY _date
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }


    // DECLARE BEHAVIORS
    public void UserInput()
    {
        _promptInput = Console.ReadLine();
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_prompt}\n{_promptInput}\n");
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
* List of Entries
- Add Entry to list 
- Display Entries
- Save Entries to a file (prompt file to user) [Include edited date]
- Load Entries from journal (replace all entries here) [display last edited date]
*/