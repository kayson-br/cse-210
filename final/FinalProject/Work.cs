using System;

public abstract class Work
{
    // ATTRIBUTES
    private string _workType;
    private string _dueDate;
    private string _status = " ";
    private string _title;
    private string _description;


    // CONSTRUCTOR
    public Work(string workType, string dueDate, string title, string description)
    {
        _workType = workType;
        _dueDate = dueDate;
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
