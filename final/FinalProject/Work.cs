using System;

public abstract class Work
{
    // ATTRIBUTES
    private string _workType;
    private string _dueDateMonth;
    private string _dueDateDay;
    private string _status = " ";
    private string _title;
    private string _description;


    // CONSTRUCTOR
    public Work(string workType, string dueDateMonth, string dueDateDay, string title, string description)
    {
        _workType = workType;
        _dueDateMonth = dueDateMonth;
        _dueDateDay = dueDateDay;
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
        List<string> list = new List<string>{_workType, _dueDateMonth, _dueDateDay, _status, _title, _description};
        return list;
    }


    // ABSTRACTS
    public abstract List<string> GetWorkInfo();
}
