using System;

public class Test : Work
{
    // ATTRIBUTES
    private string _questions;
    private string _points;


    // CONSTRUCTOR
    public Test(string dueDate, string status, string title, string description, string questions, string points)
        : base("Test", dueDate, status, title, description)
    {
        _questions = questions;
        _points = points;
    }


    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        List<string> info = GetParentInfo();
        info.Add(_questions);
        info.Add(_points);
        return info; // _workType, _dueDate, _status, _title, _description, _questions, _points
    }
}
