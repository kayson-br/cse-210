using System;

public class Subject
{
    // ATTRIBUTES
    private List<Work> _workList = new List<Work>();
    private string _subjectTitle;


    // CONSTRUCTOR
    public Subject(string subjectTitle)
    {
        _subjectTitle = subjectTitle;
    }


    // BEHAVIORS
    public string GetSubjectTitle()
    {
        return _subjectTitle;
    }

    public List<Work> GetWorkList()
    {
        return _workList;
    }

    public void AddTest() // _dueDate, _title, _description, _questions, _points
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date: ");
        string date = Console.ReadLine();
        Console.Write("Questions (Integer): ");
        string questions = Console.ReadLine();
        Console.Write("Points (Integer): ");
        string points = Console.ReadLine();

        Test test = new Test(date, title, desc, questions, points);
        _workList.Add(test);
    }

    public void AddHomework() // _dueDate, _title, _description, _points
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date: ");
        string date = Console.ReadLine();
        Console.Write("Points (Integer): ");
        string points = Console.ReadLine();

        Homework homework = new Homework(date, title, desc, points);
        _workList.Add(homework);
    }

    public void AddQuiz() // _dueDate, _title, _description, _questions, _points
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date: ");
        string date = Console.ReadLine();
        Console.Write("Questions (Integer): ");
        string questions = Console.ReadLine();
        Console.Write("Points (Integer): ");
        string points = Console.ReadLine();

        Quiz quiz = new Quiz(date, title, desc, questions, points);
        _workList.Add(quiz);
    }

    public void AddTask() // _dueDate, _title, _description
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date: ");
        string date = Console.ReadLine();

        Task task = new Task(date, title, desc);
        _workList.Add(task);
    }

    public void AddNotes() // _dueDate, _title, _description
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date: ");
        string date = Console.ReadLine();

        Notes notes = new Notes(date, title, desc);
        _workList.Add(notes);
    }

    public void Clear()
    {
        _workList.Clear();
    }
}
