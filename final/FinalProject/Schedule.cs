using System;

public class Schedule
{
    // ATTRIBUTES
    private List<Subject> _subjectList = new List<Subject>();


    // CONSTRUCTOR
    public Schedule()
    {}


    // MODULES (Private/ Functions)
    private Subject SelectSubject()
    {
            // No Subject Scenario
        if (_subjectList.Count == 0)
        {
            Console.WriteLine("\nNo subjects have been added yet.");
            return null;
        }


            // Display Subjects
        Console.WriteLine("\nSelect a subject:");
        for (int i = 0; i < _subjectList.Count; i++)
        {
            Console.WriteLine($"{i + 1}.)  {_subjectList[i].GetSubjectTitle()}");
        }


            // Grab Subject Index
        Console.Write("Enter choice: ");
        string inputString = Console.ReadLine();
        int input = int.Parse(inputString);
        if (input >= 1 && input <= _subjectList.Count)
        {
            return _subjectList[input - 1];
        }
        else
        {
            Console.WriteLine("Invalid selection.");
            return null;
        }
    }


    // MODULES (Private)
    public void AddSubject()
    {

    }

    public void DisplayAll()
    {

    }

    public void DisplayUrgent()
    {

    }

    public void DisplaySubject()
    {

    }

    public void AddWork()
    {

    }

    public void ClearWork()
    {

    }
}
