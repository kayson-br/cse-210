using System;

class SimpleGoal : Goal
{
    // CONSTRUCTORS
    public SimpleGoal(int points, string name, string description, int pointCount = 0, string checkBox = " ") : 
    base(points, name, description, pointCount, checkBox)
    {

    }


    // OVERRIDES
    // GoalType, _name, _description, _points, _pointCount, _checkBox
    public override List<string> FileFormat ()
    {
        string points = GetPoints().ToString();
        string pointCount = GetPointCount().ToString();
        List<string> load = new List<string>{"HabitGoal", GetName(), GetDescription(), points, pointCount, GetCheckBox()};

        return load;
    }
}