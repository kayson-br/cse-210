using System;

class Program
{

    /*
    DisplayWelcome - Displays the message, "Welcome to the Program!"
    PromptUserName - Asks for and returns the user's name (as a string)
    PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
    PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. 
        The out parameter is set to their birth year. This function does not return a value. 
        The user's birth year is given back from the function via the out parameter.
    SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
    DisplayResult - Accepts the user's name, the squared number, and the user's birth year. 
        Display the user's name and squared number. Calculate hold many years old they will turn this year and display that.
    */

    static void DisplaysWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        string favString = Console.ReadLine();
        int favNumber = int.Parse(favString);
        return favNumber;
    }

    static void PromptUserBirthYear(out int birthYear)
    {
        Console.WriteLine("What your birth year? ");
        string birthString = Console.ReadLine();
        birthYear = int.Parse(birthString);
    }

    static int SquareNumber(int favNumber)
    {
        int square = favNumber * favNumber;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"Your name is {name}.");
        Console.WriteLine($"Your favorite number squared is {square}");
        int age = 2025 - birthYear;
        Console.WriteLine($"You will be {age} years old this year.");

    }
    static void Main(string[] args)
    {
        DisplaysWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        PromptUserBirthYear(out int birthYear);
        int square = SquareNumber(favNumber);
        DisplayResult(userName, square, birthYear);

    }
}