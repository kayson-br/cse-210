using System;

class BreathingActivity : Activity
{

    public BreathingActivity() : base(SetName(), SetDescription())
    {
      
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
