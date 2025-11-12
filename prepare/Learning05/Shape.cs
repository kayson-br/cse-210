using System;

abstract class Shape 
{
    private string _color;

    // public Shape()
    // {
        
    // }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string input)
    {
        _color = input;
    }

    public abstract double GetArea();

}