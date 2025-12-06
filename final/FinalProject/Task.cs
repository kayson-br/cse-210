using System;

public class Task : Work
{
    // CONSTRUCTOR
    public Task(string dueDate, string status, string title, string description)
        : base("Task", dueDate, status, title, description)
    {}

    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        return GetParentInfo(); // _workType, _dueDate, _status, _title, _description, _questions, _points
    }
}
