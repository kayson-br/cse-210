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
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n\nHow long, in seconds, would you like your session? ");
        string timeString = Console.ReadLine();
        _time = int.Parse(timeString);

        // Loading
        Console.Clear();
        Load();
    }

    private static void Load()
    {
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(4);
        List<string> animation = new List<string> { "|", "/", "-", "\\"};

        while (DateTime.Now < endTime)
        {
            foreach (string s in animation)
            {
                Console.Write($"{s}");
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
        }

    }

    public void DisplayEnd()
    {
        // Initial Congratulations
        Console.WriteLine("Well Done!\n");
        Load();

        // Final End Display
        Console.Write($"You have completed {_time} seconds of the {_name}.");
        Load();
        Console.Clear();
    }

}
