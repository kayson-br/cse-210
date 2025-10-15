using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction five = new Fraction(5);
        Fraction quarters = new Fraction(3, 4);
        Fraction third = new Fraction(1, 3);

        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());

        Console.WriteLine(five.GetFractionString());
        Console.WriteLine(five.GetDecimalValue());

        Console.WriteLine(quarters.GetFractionString());
        Console.WriteLine(quarters.GetDecimalValue());

        Console.WriteLine(third.GetFractionString());
        Console.WriteLine(third.GetDecimalValue());


    }
}