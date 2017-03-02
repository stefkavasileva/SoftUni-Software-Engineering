using System;

public class CircleAreaAndPerimeter
{
    public static void Main()
    {
        double radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius * radius;
        double perimeter = 2 * Math.PI * radius;

        Console.WriteLine("Area = {0}", area);
        Console.WriteLine("Perimeter = {0}", perimeter);
    }
}