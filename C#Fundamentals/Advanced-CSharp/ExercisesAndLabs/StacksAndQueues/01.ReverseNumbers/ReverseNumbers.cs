using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ReverseNumbers
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse);

        var stack = new Stack<int>(input);
        var result = new StringBuilder();

        while (stack.Count > 0)
        {
            result.Append($"{stack.Pop()} ");
        }

        Console.WriteLine(result.ToString().Trim());
    }
}

