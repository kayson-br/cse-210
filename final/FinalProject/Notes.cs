using System;

public class Notes : Work
{
    // CONSTRUCTOR
    public Notes(string dueDate, string status, string title, string description)
        : base("Notes", dueDate, status, title, description)
    {}


    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        return GetParentInfo(); // _workType, _dueDate, _status, _title, _description, _questions, _points
    }
}
