using System;

public class TriangleFormations
{
    public static void Main()
    {
        var firstSide = int.Parse(Console.ReadLine());
        var secondSide = int.Parse(Console.ReadLine());
        var thirdSide = int.Parse(Console.ReadLine());

        var isValidTriangle = firstSide + secondSide > thirdSide &&
            firstSide + thirdSide > secondSide &&
            secondSide + thirdSide > firstSide;

        if (isValidTriangle)
        {
            Console.WriteLine("Triangle is valid.");

            var first = string.Empty;
            var second = string.Empty;

            if ((firstSide * firstSide) + (secondSide * secondSide) == thirdSide * thirdSide)
            {
                first = "a";
                second = "b";
            }
            else if ((firstSide * firstSide) + (thirdSide * thirdSide) == secondSide * secondSide)
            {
                first = "a";
                second = "c";
            }
            else if ((secondSide * secondSide) + (thirdSide * thirdSide) == firstSide * firstSide)
            {
                first = "b";
                second = "c";
            }
            else
            {
                Console.WriteLine("Triangle has no right angles");
                return;
            }

            Console.WriteLine($"Triangle has a right angle between sides {first} and {second}");
        }
        else
        {
            Console.WriteLine($"Invalid Triangle.");
        }
    }
}
