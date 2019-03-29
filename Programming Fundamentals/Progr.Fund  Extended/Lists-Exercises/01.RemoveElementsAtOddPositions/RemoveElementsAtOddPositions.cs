using System;
using System.Linq;

public class RemoveElementsAtOddPositions
{
    public static void Main()
    {
        var words = Console.ReadLine().Split().ToList();
        var elementstEvenPosition = words.Where((x, i) => i % 2 != 0).ToList(); //start from 1 not 0

        Console.WriteLine(string.Join(string.Empty,elementstEvenPosition));
    }
}
