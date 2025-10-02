using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();

        // Declare Range
        Console.Write("What is the magic number? ");
        string magic_string = Console.ReadLine();
        int magic = int.Parse(magic_string);

        // Guess
        Console.Write("What is your guess? ");
        string guess_string = Console.ReadLine();
        int guess = int.Parse(guess_string);

        // Declare Hidden Number
        int hidden = randomGenerator.Next(1, magic + 1);


        // False Guess Loop
        while (guess != hidden)
        {
            if (guess < hidden)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > hidden)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your new guess? ");
            guess_string = Console.ReadLine();
            guess = int.Parse(guess_string);

        }

        // Correct Guess Output
        Console.WriteLine("That is correct!");

    }
}

