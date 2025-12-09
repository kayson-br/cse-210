using System;

/*
        EXTRA CREDIT: This program also contains an additional function in the menu to clear the goals list
*/


class Program
{
    static void Main(string[] args)
    {
        // Initialize Variables
        Scripture scripture = new Scripture();
        string input = "";

        // First Print
        scripture.Display();
        Console.WriteLine($"\n\nPress enter to continue or type 'quit' to finish:");
        input = Console.ReadLine();

        // While Running Prints
        while (input != "quit")
        {
            scripture.HideWords();
            Console.WriteLine($"\n\nPress enter to continue or type 'quit' to finish:");
            input = Console.ReadLine();
            if (scripture.ShowSize() == 0)
            {
                break;
            }
        }
    }
}