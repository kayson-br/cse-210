using System;

public class Quiz : Work
{
    // ATTRIBUTES
    private string _questions;
    private string _points;


    // CONSTRUCTOR
    public Quiz( string dueDateMonth, string dueDateDay, string title, string description, string questions, string points)
        : base("Quiz", dueDateMonth, dueDateDay, title, description)
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
        return info; // _dueDateMonth, _dueDateDay, _title, _description, _questions, _points
    }
}