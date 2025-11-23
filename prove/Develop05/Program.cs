using System;

class Program
{
    static void Main(string[] args)
    {

        int program = 1;
        string inputString;
        int input;

        List goals = new List();
        Console.Clear();

        while (program != 0)
        {
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
                    goals.CreateGoal();
                    break;
                case 2:
                    goals.ListGoals();
                    break;
                case 3:
                    goals.SaveToFile();
                    break;
                case 4:
                    goals.LoadFromFile();
                    break;
                case 5:
                    goals.RecordEvent();
                    break;
                case 6:
                    goals.Clear(); //EXTRA CREDIT
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
    }
}