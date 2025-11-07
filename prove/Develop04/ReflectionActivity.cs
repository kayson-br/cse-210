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
        List<string> prompts = new List<string> {"did something really difficult",  //Think of a time when you
                                                "felt productive and accomplished",
                                                "made someone else happy"};
        Random random = new Random();
        int randomIndex = random.Next(0, 3);
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- Think of a time when you {prompts[randomIndex]}. --- \n");

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
            /*
                Loader = 4 seconds (create optional parameter for loader)
                if time is greater than 3 mini_prompts (12 seconds), divide total time by 3 for loader
                if time is smaller than 12 seconds, divide total time by 2 for loader, only print 2 prompts
                (else)if time is smaller than 8 seconds, loader = total time, only print 1 prompt
            */
            if (totalTime > 12)
            {
                
            }
            else if (totalTime < 12)
            {
                
            }
            else
            {
                
            }

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
        return "Reflection Activity";
    }
    
    private static string SetDescription()
    {
        return "TThis activity will help you reflect on times in your life when you have shown strength" +
        " and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
}
