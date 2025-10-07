using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        int option = 1;
        do
        {
            Console.WriteLine("MENU\n",
                              "1. Write\n",
                              "2. Display\n",
                              "3. Load\n",
                              "4. Save\n",
                              "5. Quit\n");

            option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    Entry entry = new Entry();
                    Console.Write($"{entry._prompt}\n  > ");
                    entry._promptInput = Console.ReadLine();
                    journal.AddEntry(entry);
                    Console.WriteLine("Recording Response...");
                    journal.DisplayEntries();

                    break;
                case 2:
                    Console.Write("");
                    break;
                case 3:
                    Console.Write("");
                    break;
                case 4:
                    Console.Write("");
                    break;
                case 5:
                    break;
                default:
                    Console.Write("Please select an option.");
                    break;
            }

        } while (option != 5);
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
- .AddEntry(Entry) 
- .DisplayEntries
- .SaveToFile(List<Entry>) (prompt filename to user)
- .LoadFromFile (replace all entries here) [display last edited date]
*/