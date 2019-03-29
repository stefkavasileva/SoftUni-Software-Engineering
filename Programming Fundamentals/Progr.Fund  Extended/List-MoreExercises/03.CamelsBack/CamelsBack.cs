using System;
using System.Linq;

public class CamelsBack
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        var size = int.Parse(Console.ReadLine());

        if (numbers.Count == size)
        {
            Console.WriteLine($"already stable: {string.Join(" ", numbers)}");
            return;
        }

        var rounds = (numbers.Count - size) / 2;
        var remaining = numbers.Skip(rounds).Take(size);

        Console.WriteLine($"{rounds} rounds{Environment.NewLine}remaining: {string.Join(" ", remaining)}");
    }
}

