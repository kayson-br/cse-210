using System;

class List
{
    // ATTRIBUTES
    private List<Goal> _goalList = new List<Goal>();


    // MODULES
    public void SaveToFile()
    {
        Console.Write("\nPlease input a file name:\n  > ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            
            foreach (Goal goal in _goalList)
            {
                switch (goal.FileFormat()[0])
                {
                    case "ReoccurringGoal":
                        // 0-7 (indexes)
                        // "ReoccurringGoal", GetName(), GetDescription(), progressPoints, points, progressNumerator, progressDenominator, pointCount
                        outputFile.WriteLine($"{goal.FileFormat()[0]}~{goal.FileFormat()[1]}~{goal.FileFormat()[2]}~{goal.FileFormat()[3]}" +
                                            $"~{goal.FileFormat()[4]}~{goal.FileFormat()[5]}~{goal.FileFormat()[6]}~{goal.FileFormat()[7]}");
                    break;
                    case "HabitGoal":
                        // 0-5 (indexes)
                        // GoalType, _name, _description, _points, _pointCount, _checkBox
                        outputFile.WriteLine($"{goal.FileFormat()[0]}~{goal.FileFormat()[1]}~{goal.FileFormat()[2]}~{goal.FileFormat()[3]}" +
                                            $"~{goal.FileFormat()[4]}~{goal.FileFormat()[5]}");
                    break;
                    case "SimpleGoal":
                        // 0-5 (indexes)
                        // GoalType, _name, _description, _points, _pointCount, _checkBox
                        outputFile.WriteLine($"{goal.FileFormat()[0]}~{goal.FileFormat()[1]}~{goal.FileFormat()[2]}~{goal.FileFormat()[3]}" +
                                            $"~{goal.FileFormat()[4]}~{goal.FileFormat()[5]}");
                    break;
                }
            }
        }
    }

    public void LoadFromFile()
    {
        
    }


    // GETTERS
    public List<Goal> GetGoals()
    {
        return _goalList;
    }
}
