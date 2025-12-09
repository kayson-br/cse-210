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
                    Console.Clear();
                    schedule.AddSubject(); 
                    break;
                case "2": 
                    Console.Clear();
                    schedule.AddWork(); 
                    break;
                case "3": 
                    Console.Clear();
                    schedule.DisplayAll(); 
                    break;
                case "4": 
                    Console.Clear();
                    schedule.DisplayUrgent(); 
                    break;
                case "5": 
                    Console.Clear();
                    schedule.DisplaySubject(); 
                    break;
                case "6": 
                    Console.Clear();
                    schedule.ClearWork(); 
                    break;
                case "7": 
                    Console.Clear();
                    run = false; 
                    break;
                default: 
                    Console.Clear();
                    Console.WriteLine("Invalid option."); 
                break;
            }
        }

        Console.WriteLine("Goodluck!");
    }
}