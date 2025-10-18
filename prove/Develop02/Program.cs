using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int option = 1;
        do
        {
            Console.WriteLine("\nMENU\n"+
                              "1. Write\n"+
                              "2. Display\n"+
                              "3. Load\n"+
                              "4. Save\n"+
                              "5. Clear Entries\n"+
                              "6. Quit");

            option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    // Create Entry w/ input
                    Entry entry = new Entry();
                    Console.Write($"\n{entry._prompt}\n  > ");
                    entry._promptInput = Console.ReadLine();
                    // Add Entry to Journal
                    journal.AddEntry(entry);
                    Console.WriteLine("Recording Response...");
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    journal.LoadFromFile();
                    break;
                case 4:
                    journal.SaveToFile();
                    break;
                case 5:
                    //Extra Credit Module
                    journal.ClearEntries();
                    break;
                case 6:
                    break;
                default:
                    Console.Write("\nPlease select an option.\n");
                    break;
            }

        } while (option != 6);
    }
}


/*
MAIN
Menu 
1. Write       → Create ENTRY variable function and add to default JOURNAL list
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