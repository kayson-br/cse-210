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

        // Select random prompt
        List<string> prompts = new List<string> {"When have you felt the Holy Ghost this month?",  
                                                "How can you be better this/next week?",
                                                "What is a goal you want to set or try again?"};
        Random random = new Random();
        int randomIndex = random.Next(0, 3);
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" --- {prompts[randomIndex]} --- \n");
        Console.WriteLine("You may begin in: ");
        Counter();

        //Run Activity
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_time);
        int counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write("\t> ");
            Console.ReadLine();
            counter++;
        }

        if (counter > 1)
        {
            Console.WriteLine($"You listed {counter} items!");
        }
        else
        {
            Console.WriteLine($"You listed {counter} item!");
        }
        Console.Clear();

        //DisplayEnd
        DisplayEnd();
    }

    private static string SetName()
    {
        return "Reflection Activity";
    }
    
    private static string SetDescription()
    {
        return "This activity will help you reflect on times in your life when you have shown strength" +
        " and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }
}