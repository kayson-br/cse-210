using System;

class Program
{
    static void Main()
    {
        // Declare SHAPES and LIST
        Square square = new Square("blue", 2);
        Circle circle = new Circle("red", 5);
        Rectangle rectangle = new Rectangle("purple", 3, 4);
        List<Shape> shapes = new List<Shape> { square, circle, rectangle };

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The color is {shape.GetColor()}\nThe area is {shape.GetArea()}\n");
        }
    }
}