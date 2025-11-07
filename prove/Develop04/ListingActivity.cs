using System;

class ListingActivity : Activity
{

    public ListingActivity() : base(SetName(), SetDescription())
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
            //Activity
        }

        //DisplayEnd
        DisplayEnd();
    }

    private static string SetName()
    {
        return "Reflection Activity";
    }
    
    private static string SetDescription()
    {
        return "TThis activity will help you reflect on times in your life when you have shown strength" +
        " and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
}