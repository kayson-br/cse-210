using System;

public abstract class Work
{
    // ATTRIBUTES
    protected string _workType;
    protected string _dueDate;
    protected string _status;
    protected string _title;
    protected string _description;


    // CONSTRUCTOR
    public Work(string workType, string dueDate, string status, string title, string description)
    {
        _workType = workType;
        _dueDate = dueDate;
        _status = status;
        _title = title;
        _description = description;
    }


    // BEHAVIORS
    public void UpdateStatus()
    {
        _status = "X";
    }

    public List<string> GetParentInfo()
    {
        List<string> list = new List<string>{_workType, _dueDate, _status, _title, _description};
        return list;
    }


    // ABSTRACTS
    public abstract List<string> GetWorkInfo();
}
