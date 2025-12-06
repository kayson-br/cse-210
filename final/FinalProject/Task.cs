using System;

public class Task : Work
{
    // CONSTRUCTOR
    public Task(string dueDate, string title, string description)
        : base("Task", dueDate, title, description)
    {}

    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        return GetParentInfo(); // _dueDate, _title, _description
    }
}
