using System;

class ReoccurringGoal : Goal
{
    // ATTRIBUTES
    private int _progressNumerator;
    private int _progressDenominator;
    private int _progressPoints;


    // CONSTRUCTORS
    public ReoccurringGoal(int points, string name, string description, 
                            int numerator, int denominator, int pointBonus) : 
    base(points, name, description)
    {
        _progressNumerator = numerator;
        _progressDenominator = denominator;
        _progressPoints = pointBonus;
    }


    // MODULES
    public void SetProgress(string input)
    {
        int add = int.Parse(input);

        if (add + _progressNumerator >= _progressDenominator)
        {
            _progressNumerator = _progressDenominator;
        }
        else if (add + _progressNumerator <= 0)
        {
            _progressNumerator = 0;
        }
    }

    // OVERRIDES
    // GoalType, _name, _description, _progressPoints, _points, _progressNumerator, _progressDenominator
    public override List<string> FileFormat () // POSSIBLY USE GETTERS FOR VARIABLES
    {
        List<string> load = new List<string>{"ReoccurringGoal", GetName(), GetDescription(), _porgressPoints, 
                                            GetPoints(), _progressNumerator, _progressDenominator}; 
        return load;
    }

    public override string PrintProgress ()
    {
        
    }
}