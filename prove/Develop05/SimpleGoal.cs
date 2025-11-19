using System;

class SimpleGoal : Goal
{
    // CONSTRUCTORS
    public SimpleGoal(string checkBox, int points, string name, string description) : 
    base(checkBox, points, name, description)
    {
        //put in code to auto-set some parameters
    }


    // OVERRIDES
    public override void SaveToFile ()
    {
        
    }

    public override void LoadFromFile ()
    {
        
    }

    public override void PrintProgress ()
    {
        
    }
}