using System;

public class Notes : Work
{
    // CONSTRUCTOR
    public Notes( string dueDateMonth, string dueDateDay, string title, string description)
        : base("Notes", dueDateMonth, dueDateDay, title, description)
    {}


    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        return GetParentInfo(); // _dueDateMonth, _dueDateDay, _title, _description
    }
}
