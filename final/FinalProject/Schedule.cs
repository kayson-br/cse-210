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

    private void DisplayWorkItem(Work work)
    {
        List<string> info = work.GetWorkInfo();

        string workType = info[0];
        string month = info[1];
        string day = info[2];
        string status = info[3];
        string title = info[4];
        string desc = info[5];

        Console.WriteLine($">> {title} ({workType})");
        Console.WriteLine($"\tDue: {month}/{day}");
        Console.WriteLine($"\tCompleted: {status}");
        Console.WriteLine($"\tDescription: {desc}");

        if (workType == "Test" || workType == "Quiz")
        {
            Console.WriteLine($"\tQuestions: {info[6]}");
            Console.WriteLine($"\tPoints: {info[7]}");
        }
        else if (workType == "Homework")
        {
            Console.WriteLine($"\tPoints: {info[6]}");
        }
    }



    // MODULES (Private)
    public void AddSubject()
    {
        Console.Write("Enter subject name: ");
        string name = Console.ReadLine();

        Subject subject = new Subject(name);
        _subjectList.Add(subject);
        Console.WriteLine($"Subject \"{name}\" added");
    }

    public void DisplayAll()
    {
        if (_subjectList.Count == 0)
        {
            Console.WriteLine("No subjects added yet");
            return;
        }

        foreach (Subject subject in _subjectList)
        {
            Console.WriteLine($"\n---- {subject.GetSubjectTitle()} ----");
            List<Work> works = subject.GetWorkList();

            if (works.Count == 0)
            {
                Console.WriteLine("\tNo Work Added");
            }

            foreach (Work work in works)
            {
                DisplayWorkItem(work);
            }
        }
    }

    public void DisplayUrgent()
    {
        DateTime today = DateTime.Today;
        bool foundAnything = false;

        Console.WriteLine("\n---- Urgent Work (Past Due or Due Today) ----");

        foreach (Subject subject in _subjectList)
        {
            foreach (Work work in subject.GetWorkList())
            {
                List<string> info = work.GetWorkInfo();
                int month = int.Parse(info[1]);
                int day = int.Parse(info[2]);

                if ((today.Day <= day && today.Month == month) || today.Month < month)
                {
                    foundAnything = true;

                    string statusText;
                    if (today.Day == day)
                    {
                        statusText = "(DUE TODAY)";
                    }
                    else
                    {
                        statusText = "(OVERDUE)";
                    }

                    Console.WriteLine($"{subject.GetSubjectTitle()} -> {info[4]} {statusText}  (Due {month}/{day})");
                }
            }
        }

        if (foundAnything == false){
            Console.WriteLine("No urgent work found");
        }
    }

    public void DisplaySubject()
    {
        if (_subjectList.Count == 0)
        {
            Console.WriteLine("No subjects added yet");
            return;
        }

        Subject subject = SelectSubject();
        Console.WriteLine($"\n---- {subject.GetSubjectTitle()} ----");
        List<Work> works = subject.GetWorkList();

        if (works.Count == 0)
        {
            Console.WriteLine("\tNo Work Added");
            return;
        }

        foreach (Work work in works)
        {
            DisplayWorkItem(work);
        }
    }

    public void AddWork()
    {

    }

    public void ClearWork()
    {
        if (_subjectList.Count == 0)
        {
            Console.WriteLine("No subjects added yet");
            return;
        }

        Subject subject = SelectSubject();
        
        subject.Clear();
        Console.WriteLine($"All work cleared from {subject.GetSubjectTitle()}");
    }
}
