using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var myList = new Box<int>();

        var count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine();
            myList.Add(int.Parse(input));
        }

        var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        myList.Swap(indexes[0], indexes[1]);

        Console.WriteLine(myList);
    }
}

