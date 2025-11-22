using System;

class List
{
    // ATTRIBUTES
    private List<Goal> _goalList = new List<Goal>();


    // MODULES

    public void CreateGoal()
    {
        int program = 1;
        string inputString;
        int input;

        while (program != 0)
        {
            string name;
            string description;
            int points;
            

            Console.Clear();
            Console.Write("\nSelect a goal type:\n" +
                            "\t1. Simple Goal\n" +
                            "\t2. Habit Goal\n" +
                            "\t3. Checklist Goal\n" +
                            "Select a choice from the menu: ");
            inputString = Console.ReadLine();
            input = int.Parse(inputString);

            switch (input)
            {
                case 1: // Simple Goal
                    // CONSTRUCTOR: int points, string name, string description, int pointCount = 0, string checkBox = " "
                    Console.WriteLine("Name of the goal: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Description of the goal:");
                    description = Console.ReadLine();
                    Console.WriteLine("Points goal is worth at completion:");
                    points = int.Parse(Console.ReadLine());

                    SimpleGoal sGoal = new SimpleGoal(points, name, description);
                    _goalList.Add(sGoal);

                    Console.Clear();
                    Console.WriteLine("Goal Added\n");
                    break;
                case 2: // Habit Goal
                    // CONSTRUCTOR: int points, string name, string description, int pointCount = 0, string checkBox = " "
                    Console.WriteLine("Name of the goal: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Description of the goal:");
                    description = Console.ReadLine();
                    Console.WriteLine("Points goal is worth at completion:");
                    points = int.Parse(Console.ReadLine());

                    HabitGoal hGoal = new HabitGoal(points, name, description);
                    _goalList.Add(hGoal);

                    Console.Clear();
                    Console.WriteLine("Goal Added\n");
                    break;
                case 3: // Checklist Goal

                    int numerator = 0;
                    int denominator;
                    int pointBonus;

                    // CONSTRUCTOR: int points, string name, string description, int numerator, int denominator, int pointBonus, int pointCount = 0, string checkBox = " "
                    Console.WriteLine("Name of the goal: ");
                    name = Console.ReadLine();
                    Console.WriteLine("Description of the goal:");
                    description = Console.ReadLine();
                    Console.WriteLine("Times until finished:");
                    denominator = int.Parse(Console.ReadLine());
                    Console.WriteLine("Points after each goal completion:");
                    pointBonus = int.Parse(Console.ReadLine());
                    Console.WriteLine("Bonus points for completing overall goal:");
                    points = int.Parse(Console.ReadLine());

                    ReoccurringGoal rGoal = new ReoccurringGoal(points, name, description, numerator, denominator, pointBonus);
                    _goalList.Add(rGoal);

                    Console.Clear();
                    Console.WriteLine("Goal Added\n");
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select an option\n");
                    break;
            }
            Console.Clear();
        }
    }









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
        string[] lines = System.IO.File.ReadAllLines(filename);

        // Parse goal file into a list
        Console.WriteLine($"Loading in entries from {filename}...");
        foreach (string line in lines)
        {
            string[] goalAttributes = line.Split("~"); // "GoalType, _name, _description, _points, _pointCount, _checkBox"

            string name = goalAttributes[1];
            string description = goalAttributes[2];
            int points = int.Parse(goalAttributes[3]);
            int pointCount = int.Parse(goalAttributes[4]);
            string checkBox = goalAttributes[5];

            switch (goalAttributes[0])
            {
                case "ReoccurringGoal":
                    // 0-8 (indexes)
                    // goalAttributes: GoalType[0], _name[1], _description[2], _points[3], _pointCount[4], _checkBox[5], _progressPoints[6],  _progressNumerator[7], _progressDenominator[8]
                    int progressPoints = int.Parse(goalAttributes[6]);
                    int progressNumerator = int.Parse(goalAttributes[7]);
                    int progressDenominator = int.Parse(goalAttributes[8]);
                        
                    // CONSTRUCTOR: int points, string name, string description, int numerator, int denominator, int pointBonus, int pointCount = 0, string checkBox = " "
                    ReoccurringGoal rGoal = new ReoccurringGoal(points, name, description, progressNumerator, progressDenominator, progressPoints, pointCount, checkBox);
                    _goalList.Add(rGoal);
                break;
                case "HabitGoal":
                    // 0-5 (indexes)
                    // LOAD IN: GoalType[0], _name[1], _description[2], _points[3], _pointCount[4], _checkBox[5]
                    // CONSTRUCTOR: int points, string name, string description, int pointCount = 0, string checkBox = " "
                    HabitGoal hGoal = new HabitGoal(points, name, description, pointCount, checkBox);
                    _goalList.Add(hGoal);
                break;
                case "SimpleGoal":
                    // 0-5 (indexes)
                    // LOAD IN: GoalType[0], _name[1], _description[2], _points[3], _pointCount[4], _checkBox[5]
                    // CONSTRUCTOR: int points, string name, string description, int pointCount = 0, string checkBox = " "
                    SimpleGoal sGoal = new SimpleGoal(points, name, description, pointCount, checkBox);
                    _goalList.Add(sGoal);
                break;
            }
        }
    }


    // GETTERS
    public List<Goal> GetGoals()
    {
        return _goalList;
    }
}
