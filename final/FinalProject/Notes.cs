using System;

public class Notes : Work
{
    // CONSTRUCTOR
    public Notes(string dueDate, string title, string description)
        : base("Notes", dueDate, title, description)
    {}


    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        return GetParentInfo(); // _dueDate, _title, _description
    }
}
