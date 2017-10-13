using System;

public class Shapes
{
    public static void Main()
    {
        Shape rectangle = new Rectangle(3.0, 4.0);
        Shape circle = new Circle(5.0);
        
        Console.WriteLine(rectangle.CalculateArea());
        Console.WriteLine(circle.CalculateArea());
    }
}