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
            Console.Write("\nMenu Options:\n" +
                            "\t1. Create New Goal\n" +
                            "\t2. List Goals\n" +
                            "\t3. Save Goals\n" +
                            "\t4. Load Goals\n" + 
                            "\t5. Record Event\n" +
                            "\t6. Clear Goals\n" +
                            "\t7. Quit\n" +
                            "Select a choice from the menu: ");
            inputString = Console.ReadLine();
            input = int.Parse(inputString);

            switch (input)
            {
                case 7:
                    program = 0;
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                default:
                    Console.Clear();
                    break;
            }
            Console.Clear();
        }


    }
}