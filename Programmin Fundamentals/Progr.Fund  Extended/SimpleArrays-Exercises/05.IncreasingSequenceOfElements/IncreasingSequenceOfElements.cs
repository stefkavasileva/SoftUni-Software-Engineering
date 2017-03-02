using System;
using System.Linq;

public class IncreasingSequenceOfElements
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        var hasInvreasingSeq = true;

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] >= numbers[i + 1])
            {
                hasInvreasingSeq = false;
                break;
            }
        }

        if (hasInvreasingSeq) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}
