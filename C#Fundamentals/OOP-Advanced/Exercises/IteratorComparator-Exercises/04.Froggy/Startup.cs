using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);

        var stones = new Lake(numbers.ToList());

        Console.WriteLine(string.Join(", ",stones));
    }
}

