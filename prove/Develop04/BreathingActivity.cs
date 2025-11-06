using System;

class BreathingActivity : Activity
{

    public BreathingActivity() : base(SetName(), SetDescription())
    {
        // input time
    }

    public void Activity()
    {

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
