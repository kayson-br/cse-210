using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWhat is your first name?");
        string first = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");

        //error error
    }
}


/*
using System;

class Notes
{
    static void Main(string[] args)
    {
        // Define Variables
        int x;
        x = 5;
        Console.WriteLine(x);
        /*
        int - Integers (whole numbers, positive and negative)
        string - Strings (a sequence of characters, including letters, numbers, or symbols)
        float - Floating point numbers (numbers that use decimals)
        double - Double precision floating point numbers (just like a float, except it takes up twice as much memory, so it can hold larger numbers or numbers with more decimal places)
        bool - Boolean variables (true or false)
        */
/*
        // Print Statements
        Console.WriteLine("Normal print statement");
        Console.Write("No new line after");

        // Input
        Console.Write("What is your favorite color? ");
        string color = Console.ReadLine();

        // Blocks { }
        x = 3;
        int y = 2;
        if (x > y)
        {
            Console.WriteLine("greater");
        }

        // Print Format
        string school = "BYU-Idaho";
        Console.WriteLine($"I am studying at {school}."); //  $ = f
    }
}
*/