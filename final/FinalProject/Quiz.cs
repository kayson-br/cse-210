using System;

public class Quiz : Work
{
    // ATTRIBUTES
    private string _questions;
    private string _points;


    // CONSTRUCTOR
    public Quiz(string dueDate, string status, string title, string description, string questions, string points)
        : base("Quiz", dueDate, status, title, description)
    {
        _questions = questions;
        _points = points;
    }


    // OVERRIDES
    public override List<string> GetWorkInfo()
    {
        var info = GetParentInfo();
        info.Add(_questions);
        info.Add(_points);
        return info;
    }
}