using System;

class ReoccurringGoal : Goal
{
    // ATTRIBUTES
    private int _progressNumerator;
    private int _progressDenominator;
    private int _progressPoints;


    // CONSTRUCTORS
    public ReoccurringGoal(int points, string name, string description, int numerator, 
                        int denominator, int pointBonus, int pointCount = 0, string checkBox = " ") : 
    base(points, name, description, pointCount, checkBox)
    {
        _progressNumerator = numerator;
        _progressDenominator = denominator;
        _progressPoints = pointBonus;
    }


    // MODULES
    public void SetNumerator(int input)
    {
        _progressNumerator = input;
    }

    public void SetDenominator(int input)
    {
        _progressDenominator = input;
    }

    public int GetNumerator()
    {
        return _progressNumerator;
    }

    public int GetDenominator()
    {
        return _progressDenominator;
    }

    public int GetProgressPoints()
    {
        return _progressPoints;
    }


    // OVERRIDES
    // GoalType, _name, _description, _points, _pointCount, _checkBox _progressPoints,  _progressNumerator, _progressDenominator
    public override List<string> FileFormat ()
    {
        string progressPoints = _progressPoints.ToString();
        string progressNumerator = _progressNumerator.ToString();
        string progressDenominator = _progressDenominator.ToString();
        string pointCount = GetPointCount().ToString();
        string points = GetPoints().ToString();
        string checkBox = GetCheckBox();

        List<string> load = new List<string>{"ReoccurringGoal", GetName(), GetDescription(), points, pointCount,
                                            checkBox, progressPoints, progressNumerator, progressDenominator}; 

        return load;
    }
}