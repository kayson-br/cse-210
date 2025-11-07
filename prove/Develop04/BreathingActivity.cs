using System;

class BreathingActivity : Activity
{

    public BreathingActivity() : base(SetName(), SetDescription())
    {
        // input time
    }

    public void Activity()
    {
        //DisplayStart
        DisplayStart();


        //Run Activity
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreath in... ");
            Counter();
            Console.WriteLine("Breath out... ");
            Counter();
        }

        //DisplayEnd
        DisplayEnd();
    }

    private static void Counter()
    {
        for (int i = 4; i > 0; i--)
        {
            Console.Write($"\b{i}");
            Thread.Sleep(1000);
        }
        Console.Write($"\b \b");
    }

    private static string SetName()
    {
        return "Breathing Activity";
    }
    
    private static string SetDescription()
    {
        return "This activity will help you relax by walking your breathing in and out slowly." +
        " Clear your mind and focus on your breathing.";
    }
}
