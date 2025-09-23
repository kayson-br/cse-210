using System;
// This ^ includes standard libraries such as lists

class Program
{
    static void Main(string[] args)
    {
        /*
        Enter a list of numbers, type 0 when finished.
        Enter number: 18
        Enter number: 36
        Enter number: 0
        The sum is: 131
        The average is: 18.714285714285715
        The largest number is: 48
        */

        string input_string;
        int input = 1;
        int high = 0;
        int sum = 0;
        float average = 0;
        int count = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Loop Inputs
        do
        {
            // Input Number to List
            Console.Write("Enter number: ");
            input_string = Console.ReadLine();
            input = int.Parse(input_string);
            if (input != 0)
            {
                count += 1;
            }

            // Adjust Highest Input
                if (high < input)
                {
                    high = input;
                }

            // Adjust Sum
            sum += input;

        } while (input != 0);

        // Adjust Average
        average = sum / (float)count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {high}");

    }
}