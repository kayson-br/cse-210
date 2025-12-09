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

    public void AddTest() // _dueDateMonth, _dueDateDay, _title, _description, _questions, _points
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date Month (Integer): ");
        string dateMonth = Console.ReadLine();
        Console.Write("Due Date Day (Integer): ");
        string dateDay = Console.ReadLine();
        Console.Write("Questions (Integer): ");
        string questions = Console.ReadLine();
        Console.Write("Points (Integer): ");
        string points = Console.ReadLine();

        Test test = new Test(dateMonth, dateDay, title, desc, questions, points);
        _workList.Add(test);
    }

    public void AddHomework() // _dueDateMonth, _dueDateDay, _title, _description, _points
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date Month (Integer): ");
        string dateMonth = Console.ReadLine();
        Console.Write("Due Date Day (Integer): ");
        string dateDay = Console.ReadLine();
        Console.Write("Points (Integer): ");
        string points = Console.ReadLine();

        Homework homework = new Homework(dateMonth, dateDay, title, desc, points);
        _workList.Add(homework);
    }

    public void AddQuiz() // _dueDateMonth, _dueDateDay, _title, _description, _questions, _points
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date Month (Integer): ");
        string dateMonth = Console.ReadLine();
        Console.Write("Due Date Day (Integer): ");
        string dateDay = Console.ReadLine();
        Console.Write("Questions (Integer): ");
        string questions = Console.ReadLine();
        Console.Write("Points (Integer): ");
        string points = Console.ReadLine();

        Quiz quiz = new Quiz(dateMonth, dateDay, title, desc, questions, points);
        _workList.Add(quiz);
    }

    public void AddTask() // _dueDateMonth, _dueDateDay, _title, _description
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date Month (Integer): ");
        string dateMonth = Console.ReadLine();
        Console.Write("Due Date Day (Integer): ");
        string dateDay = Console.ReadLine();

        Task task = new Task(dateMonth, dateDay, title, desc);
        _workList.Add(task);
    }

    public void AddNotes() // _dueDateMonth, _dueDateDay, _title, _description
    {
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Due Date Month (Integer): ");
        string dateMonth = Console.ReadLine();
        Console.Write("Due Date Day (Integer): ");
        string dateDay = Console.ReadLine();

        Notes notes = new Notes(dateMonth, dateDay, title, desc);
        _workList.Add(notes);
    }

    public void Clear()
    {
        _workList.Clear();
    }
}