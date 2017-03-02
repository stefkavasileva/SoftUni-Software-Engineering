using System;

public class SquareArea
{
    public static void Main()
    {
        Console.Write("a= ");

        double side = double.Parse(Console.ReadLine());
        double area = side * side;

        Console.Write("Sqare = ");
        Console.WriteLine(area);
    }
}
