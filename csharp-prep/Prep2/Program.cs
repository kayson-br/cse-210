using System;

class Program
{
    static void Main(string[] args)
    {

        // AND  &&
        // OR ||
        // NOT !

        // Can not change variable type. Must re-declare
        /*
        Console.Write("What is your favorite number? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);  --> define variable type and parse
        
        int number = 42;
        string textVersion = number.ToString();
        */

        Console.WriteLine("What was your grade percentage?");
        string userGrade = Console.ReadLine();
        int grade = int.Parse(userGrade);
        char letter = 'A';

        // Grade Selection
        if (grade <= 60)
        {
            letter = 'F';
        }
        else if (grade <= 70)
        {
            letter = 'D';
        }
        else if (grade <= 80)
        {
            letter = 'C';
        }
        else if (grade <= 90)
        {
            letter = 'B';
        }

        // Pass or Fail  |  Print Results
        if (grade >= 70)
        {
            Console.WriteLine($"You Passed with a {letter}!");
        }
        else if (grade < 70)
        {
            Console.WriteLine($"You Failed with a {letter}!");
        }
    }
}