using System;

class Activity
{
    private string _name;
    private string _description;
    public int _time;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStart()
    {
        // Initial Display
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n\nHow long, in seconds, would you like your session? ");
        string timeString = Console.ReadLine();
        _time = int.Parse(timeString);

        // Loading
        Console.Clear();
        Console.WriteLine("Get ready...");
        Load();
    }

    public void Load(int time = 4)
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);
        List<string> animation = new List<string> { "|", "/", "-", "\\"};

        while (DateTime.Now < endTime)
        {
            foreach (string s in animation)
            {
                Console.Write($"\b{s}");
                Thread.Sleep(100);
            }
            Console.Write($"\b ");
        }

    }

    public void DisplayEnd()
    {
        // Initial Congratulations
        Console.WriteLine("\nWell Done!");
        Load();

        // Final End Display
        Console.WriteLine($"\nYou have completed {_time} seconds of the {_name}.");
        Load();
        Console.Clear();
    }

    public void Counter()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write($"\b{i}");
            Thread.Sleep(1000);
        }
        Console.Write($"\b \b");
    }

}
