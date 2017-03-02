using System;

public class AreaOfFigures
{
    public static void Main()
    {
        string figure = Console.ReadLine().ToLower();

        double areaOfFigure = 0;

        if (figure.Equals("square"))
        {
            double side = double.Parse(Console.ReadLine());
            areaOfFigure = side * side;

        }
        else if (figure.Equals("rectangle"))
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            areaOfFigure = a * b;
        }
        else if (figure.Equals("circle"))
        {
            double radius = double.Parse(Console.ReadLine());
            areaOfFigure = Math.PI * radius * radius;
        }
        else if (figure.Equals("triangle"))
        {
            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            areaOfFigure = (side * h) / 2;
        }

        Console.WriteLine("{0}", Math.Round(areaOfFigure, 3));
    }
}
