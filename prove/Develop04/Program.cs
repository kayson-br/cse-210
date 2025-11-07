using System;

class Program
{
    static void Main(string[] args)
    {
        int program = 1;
        string inputString;
        int input;
        int breathingCounter = 0;
        int reflectionCounter = 0;
        int listingCounter = 0;
        while (program != 0)
        {
            Console.Clear();
            Console.Write("\nMenu Options:\n" +
                            "\t1. Start breathing activity\n" +
                            "\t2. Start relecting activity\n" +
                            "\t3. Start listing activity\n" +
                            "\t4. Activity count\n" + 
                            "\t5. Quit\n" +
                            "Select a choice from the menu: ");
            inputString = Console.ReadLine();
            input = int.Parse(inputString);

            switch (input)
            {
                case 5:
                    program = 0;
                    break;
                case 1:
                    BreathingActivity activity1 = new BreathingActivity();
                    activity1.Activity();
                    breathingCounter++;
                    break;
                case 2:
                    ReflectionActivity activity2 = new ReflectionActivity();
                    activity2.Activity();
                    reflectionCounter++;
                    break;
                case 3:
                    ListingActivity activity3 = new ListingActivity();
                    activity3.Activity();
                    listingCounter++;
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine($"ACTIVITY COUNT\n" +
                                    $"\tBreathing Activity: {breathingCounter}\n" +
                                    $"\tReflection Activity: {reflectionCounter}\n" +
                                    $"\tListing Activity: {listingCounter}");
                    Console.WriteLine("Hit \"Enter\" to return to menu: ");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    break;
            }
            Console.Clear();
        }

    }
}