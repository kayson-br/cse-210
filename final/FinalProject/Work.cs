using System;

public abstract class Work
{
    protected string _workType;
    protected string _dueDate;
    protected string _status;
    protected string _title;
    protected string _description;

    public Work(string workType, string dueDate, string status, string title, string description)
    {
        _workType = workType;
        _dueDate = dueDate;
        _status = status;
        _title = title;
        _description = description;
    }

    public void UpdateStatus()
    {
        Console.Write("Enter new status: ");
        _status = Console.ReadLine();
    }

    public List<string> GetParentInfo()
    {
        return new List<string>
        {
            _workType, _dueDate, _status, _title, _description
        };
    }

    public abstract List<string> GetWorkInfo();
}
