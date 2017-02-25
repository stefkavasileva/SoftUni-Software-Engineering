using System;
using System.Linq;

public class TearListInHalf
{
    public static void Main()
    {
        var inputNums = Console.ReadLine().Split().Select(int.Parse).ToList();

        var leftNums = inputNums.Take(inputNums.Count / 2).ToList();
        var rightNums = inputNums.Skip(inputNums.Count / 2).ToList();

        var count = 0;
        var index = 0;
        while (true)
        {
            var firstDigit = rightNums[count] / 10 % 10;
            var lastDigit = rightNums[count] % 10;

            leftNums.Insert(index, firstDigit);
            leftNums.Insert(index + 2, lastDigit);
            count++;
            index += 3;

            if (count == rightNums.Count())
            {
                break;
            }
        }

        Console.WriteLine(string.Join(" ", leftNums));
    }
}
