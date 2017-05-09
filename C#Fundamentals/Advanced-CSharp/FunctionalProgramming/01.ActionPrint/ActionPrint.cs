using System;
using System.Linq;

public class ActionPrint
{
    public static void Main()
    {
        var text = Console.ReadLine().Split().ToArray();
        Action<string[]> action = Print;
        action(text);
    }

    public static void Print (string [] text)
    {
        foreach (var item in text)
        {
            Console.WriteLine(item);
        }
    }
}

