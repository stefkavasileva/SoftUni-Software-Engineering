using System;

public class TriangleFormations
{
    public static void Main()
    {
        var a = int.Parse(Console.ReadLine());
        var b = int.Parse(Console.ReadLine());
        var c = int.Parse(Console.ReadLine());

        var triangleValidityCondition1 = a + b > c;
        var triangleValidityCondition2 = b + c > a;
        var triangleValidityCondition3 = a + c > b;

        var isValidTriangle = triangleValidityCondition1 && triangleValidityCondition2 && triangleValidityCondition3;

        if (isValidTriangle)
        {
            Console.WriteLine("Triangle is valid.");
        }
        else
        {
            Console.WriteLine("Invalid Triangle.");
            return;
        }

        var rightTriangleCondition1 = a * a + b * b == c * c;
        var rightTriangleCondition2 = b * b + c * c == a * a;
        var rightTriangleCondition3 = a * a + c * c == b * b;

        if (rightTriangleCondition1)
            Console.WriteLine("Triangle has a right angle between sides a and b");
        else if (rightTriangleCondition2)
            Console.WriteLine("Triangle has a right angle between sides b and c");
        else if (rightTriangleCondition3)
            Console.WriteLine("Triangle has a right angle between sides a and c");
        else
            Console.WriteLine("Triangle has no right angles.");
    }
}
