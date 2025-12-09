using System;

public class Task : Work
{
    // CONSTRUCTOR
    public Task( string dueDateMonth, string dueDateDay, string title, string description)
        : base("Task", dueDateMonth, dueDateDay, title, description)
    {}


    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        return GetParentInfo(); // _dueDateMonth, _dueDateDay, _title, _description
    }
}