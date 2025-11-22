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
    public void SetProgress(int input)
    {
        if (input + _progressNumerator >= _progressDenominator)
        {
            _progressNumerator = _progressDenominator;
        }
        else if (input + _progressNumerator <= 0)
        {
            _progressNumerator = 0;
        }
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