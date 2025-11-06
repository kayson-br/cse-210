using System;

class Program
{
    static void Main(string[] args)
    {
        int program = 1;
        string inputString;
        int input;
        while (program != 0)
        {
            Console.Clear();
            Console.Write("\nMenu Options:\n"+
                            "\t1. Start breathing activity\n"+
                            "\t2. Start relecting activity\n"+
                            "\t3. Start listing activity\n"+
                            "\t4. Quit\n"+
                            "Select a choice from the menu: ");
            inputString = Console.ReadLine();
            input = int.Parse(inputString);

            switch (input)
            {
                case 4:
                    program = 0;
                    break;
                case 1:
                    BreathingActivity activity = new BreathingActivity();
                    activity.Activity();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    Console.Clear();
                    break;
            }
            Console.Clear();
        }

        //Create menu
        //Select Activity.Program()
    }
}