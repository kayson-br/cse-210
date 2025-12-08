using System;

class Program
{
    static void Main()
    {
        Schedule schedule = new Schedule();
        bool run = true;

        while (run)
        {
            Console.WriteLine("\n==== Homework Schedule Menu ====");
            Console.WriteLine("1. Add Subject");
            Console.WriteLine("2. Add Work");
            Console.WriteLine("3. Display All Work");
            Console.WriteLine("4. Display Urgent Work");
            Console.WriteLine("5. Display Subject");
            Console.WriteLine("6. Clear All Work From Subject");
            Console.WriteLine("7. Exit");
            Console.Write("Choose: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1": 
                    schedule.AddSubject(); 
                    break;
                case "2": 
                    schedule.AddWork(); 
                    break;
                case "3": 
                    schedule.DisplayAll(); 
                    break;
                case "4": 
                    schedule.DisplayUrgent(); 
                    break;
                case "5": 
                    schedule.DisplaySubject(); 
                    break;
                case "6": 
                    schedule.ClearWork(); 
                    break;
                case "7": 
                    run = false; 
                    break;
                default: 
                    Console.WriteLine("Invalid option."); 
                break;
            }
        }

        Console.WriteLine("Goodluck!");
    }
}