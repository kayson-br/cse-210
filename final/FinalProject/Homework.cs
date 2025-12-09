using System;

public class Homework : Work
{
    // ATTRIBUTES
    private string _points;


    // CONSTRUCTORS
    public Homework( string dueDateMonth, string dueDateDay, string title, string description, string points)
        : base("Homework", dueDateMonth, dueDateDay, title, description)
    {
        _points = points;
    }


    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        List<string> info = GetParentInfo();
        info.Add(_points);
        return info; // _dueDateMonth, _dueDateDay, _title, _description, _points
    }
}