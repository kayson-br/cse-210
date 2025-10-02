using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2020;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "IT Specialist";
        job2._startYear = 2019;
        job2._endYear = 2020;

        Resume resume1 = new Resume();
        resume1._name = "Kayson Brown";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // Display Resume
        resume1.Display();

        // Display Specified Job title
        Console.WriteLine($"\n{resume1._jobs[0]._jobTitle}");

    }
}