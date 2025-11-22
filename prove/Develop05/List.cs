using System;

class List
{
    // ATTRIBUTES
    List<Goal> _goalList = new List<Goal>();


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
                        // 0-6 (indexes)
                        // "ReoccurringGoal", GetName(), GetDescription(), progressPoints, points, progressNumerator, progressDenominator
                        outputFile.WriteLine($"{goal.FileFormat()[0]}~{goal.FileFormat()[1]}~{goal.FileFormat()[2]}~{goal.FileFormat()[3]}" +
                                            $"~{goal.FileFormat()[4]}~{goal.FileFormat()[5]}~{goal.FileFormat()[6]}");
                    break;
                    case "HabitGoal":
                    break;
                    case "SimpleGoal":
                    break;
                }
            }
        }
    }

    public void LoadFromFile()
    {
        
    }

    //Count total points     List.CountPOints();


    // GETTERS
    public List<Goal> GetGoals()
    {
        return ;
    }


    // SETTERS
    // Create Goal
}

/*
EternalGoal, name, description, points
SimmpleGoal, name, description, points
ReoccurringGoal, name, description, points
RandomGoal, name, description, points
*/

// EternalGoal goal = new EternalGoal{name, description, points};
// SimpleGoal goal = new SimpleGoal{name, description, points};
// list.add(goal);