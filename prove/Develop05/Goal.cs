using System;

abstract class Goal
{
    // ATTRIBUTES
    private string _checkBox = " ";
    private int _points;
    private string _name;
    private string _description; 
    private int _pointCount = 0;
    // totalpoints


    // CONSTRUCTOR
    public Goal(int points, string name, string description)
    {
        _points = points;
        _name = name;
        _description = description;
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

    public void SetPointCount(int add)
    {
        _pointCount += add;
    }


    // ABSTRACTS
    public abstract List<string> FileFormat();
}