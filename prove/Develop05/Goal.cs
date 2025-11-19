using System;

abstract class Goal
{
    // ATTRIBUTES
    private string _checkBox = " ";
    private int _points;
    private string _name;
    private string _description; 


    // CONSTRUCTOR
    public Goal(int points, string name, string description)
    {
        
    }


    // MODULES
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetCheckBox()
    {
        _checkBox = "x";
    }

    public string GetCheckBox()
    {
        return _checkBox;
    }

    public int GetPoints()
    {
        return _points;
    }


    // ABSTRACTS
    public abstract List<string> FileFormat();
    public abstract string PrintProgress();
}