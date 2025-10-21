using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        string input = "";
        scripture.Display();
        Console.WriteLine($"\n\nPress enter to continue or type 'quit' to finish:");
        input = Console.ReadLine();

        while (input!="quit")
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