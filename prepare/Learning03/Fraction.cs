
using System;

public class Fraction
{

    private int _top;
    private int _bottom;

    // CONSTRUCTORS

    //no-attributes
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    //one-attribute
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    //two-attributes
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // METHODS

    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetTop(int number)
    {
        _top = number;
    }
    public void SetBottom(int number)
    {
        _bottom = number;
    }

    public string GetFractionString()
    {
        return ($"{_top}/{_bottom}");
    }
    public double GetDecimalValue()
    {
        return (_top / _bottom);
    }
}