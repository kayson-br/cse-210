using System;

public class Homework : Work
{
    // ATTRIBUTES
    private string _points;


    // CONSTRUCTORS
    public Homework(string dueDate, string title, string description, string points)
        : base("Homework", dueDate, title, description)
    {
        _points = points;
    }


    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        List<string> info = GetParentInfo();
        info.Add(_points);
        return info; // _dueDate, _title, _description, _points
    }
}
