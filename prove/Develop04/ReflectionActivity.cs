using System;

class ReflectionActivity : Activity
{

    public ReflectionActivity() : base(SetName(), SetDescription())
    {
      
    }

    public void Activity()
    {
        //DisplayStart
        DisplayStart();

        // Select random prompt
        List<string> prompts = new List<string> {"did something really difficult",  
                                                "felt productive and accomplished",
                                                "made someone else happy"};
        Random random = new Random();
        int randomIndex = random.Next(0, 3);
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- Think of a time when you {prompts[randomIndex]} --- \n");

        // Press enter to start
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        // Starts in a few seconds
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        Counter();
        Console.Clear();

        //Run Activity
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        TimeSpan difference = endTime - startTime;
        int totalTime = (int)difference.TotalSeconds;

        while (DateTime.Now < endTime)
        {
            if (totalTime >= 12)
            {
                Console.Write("\t> How did you feel afterwards?  ");
                Load(totalTime/3);
                Console.Write("\n\t> Why do you think you felt this way?  ");
                Load(totalTime/3);
                Console.Write("\n\t> What can you take away from this into the future?  ");
                Load(totalTime/3);
                break;
            }
            else if (totalTime >= 8)
            {
                Console.Write("\t> How did you feel afterwards?  ");
                Load(totalTime/2);
                Console.Write("\n\t> Why do you think you felt this way?  ");
                Load(totalTime / 2);
                break;
            }
            else
            {
                Console.Write("\t> How did you feel afterwards?  ");
                Load(totalTime);
                break;
            }

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
