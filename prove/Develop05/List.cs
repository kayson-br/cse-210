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
                        // GoalType, GetName(), GetDescription(), progressPoints, points, progressNumerator, progressDenominator, pointCount
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
        // Input Filename
        Console.Write("\nPlease input a file name:\n  > ");
        string filename = Console.ReadLine();

        // Create list of lines
        List<Goal> goalList = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Parse goal file into a list
        Console.WriteLine($"Loading in entries from {filename}...");
        foreach (string line in lines)
        {
            string[] goalAttributes = line.Split("~"); // "GoalType, _name, _description, _points, _pointCount, _checkBox"

            switch (goalAttributes[0])
                {
                    case "ReoccurringGoal":
                        // 0-8 (indexes)
                        // goalAttributes: GoalType[0], _name[1], _description[2], _points[3], _pointCount[4], _checkBox[5], _progressPoints[6],  _progressNumerator[7], _progressDenominator[8]
                        string name = goalAttributes[1];
                        string description = goalAttributes[2];
                        int points = int.Parse(goalAttributes[3]);
                        int pointCount = int.Parse(goalAttributes[4]);
                        string checkBox = goalAttributes[5];
                        int progressPoints = int.Parse(goalAttributes[6]);
                        int progressNumerator = int.Parse(goalAttributes[7]);
                        int progressDenominator = int.Parse(goalAttributes[8]);
                        
                        // CONSTRUCTOR: int points, string name, string description, int numerator, int denominator, int pointBonus, int pointCount = 0, string checkBox = " "
                        ReoccurringGoal goal = new ReoccurringGoal(points, name, description, progressNumerator, progressDenominator, progressPoints, pointCount, checkBox);
                    break;
                    case "HabitGoal":
                        // 0-5 (indexes)
                        // LOAD IN: GoalType[0], _name[1], _description[2], _points[3], _pointCount[4], _checkBox[5]
                        
                    break;
                    case "SimpleGoal":
                        // 0-5 (indexes)
                        // LOAD IN: GoalType[0], _name[1], _description[2], _points[3], _pointCount[4], _checkBox[5]
                        
                    break;
                }

            // string[] entryAttributes = line.Split("~"); // "entry._date" "entry._prompt" "entry._promptInput"

            // Entry entry = new Entry();
            // entry._date = entryAttributes[0];
            // entry._prompt = entryAttributes[1];
            // entry._promptInput = entryAttributes[2];

            // newEntries.Add(entry);
        }

        // Send to Journal class entry list
        _goalList = goalList;
    }


    // GETTERS
    public List<Goal> GetGoals()
    {
        return _goalList;
    }
}
