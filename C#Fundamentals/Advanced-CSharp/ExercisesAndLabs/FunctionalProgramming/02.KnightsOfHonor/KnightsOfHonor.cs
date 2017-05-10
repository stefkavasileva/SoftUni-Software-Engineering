using System;
using System.Linq;

public class KnightsOfHonor
{
    public static void Main()
    {
        var names = Console.ReadLine().Split().Where(x => x != string.Empty).ToArray();
        Action<string[]> action = PrintSir;
        action(names);
    }

    public static void PrintSir(string [] names)
    {
        foreach (var name in names)
        {
            Console.WriteLine($"Sir {name}");
        }
    }
}
