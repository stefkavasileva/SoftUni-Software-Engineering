using System;
using System.Linq;

public class ArraySymmetry
{
    public static void Main()
    {
        var inputArr = Console.ReadLine().Split().ToArray();

        var leftPart = inputArr.Take(inputArr.Length / 2).ToArray();
        var rightPart = inputArr.Length % 2 == 0 ?
            inputArr.Skip(inputArr.Length / 2).ToArray() :
            inputArr.Skip(inputArr.Length / 2 + 1).ToArray();
        Array.Reverse(rightPart);

        var isSimetric = true;
        for (int i = 0; i < leftPart.Length; i++)
        {
            if (leftPart[i] != rightPart[i])
            {
                isSimetric = false;
                break;
            }
        }

        var result = isSimetric ? "Yes" : "No";
        Console.WriteLine(result);
    }
}
