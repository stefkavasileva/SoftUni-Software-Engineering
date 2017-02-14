using System;
using System.Linq;
using System.Numerics;

public class Convert
{
    public static void Main()
    {
        var inputNums = Console.ReadLine().Split().ToArray();
        var baseNum = BigInteger.Parse(inputNums[0]);
        var numsToConvert = BigInteger.Parse(inputNums[1]);

        string result = string.Empty;

        while (numsToConvert > 0)
        {
            var remainder = numsToConvert % baseNum;
            result = remainder.ToString() + result;
            numsToConvert /= baseNum;
        }

        Console.WriteLine(result);
    }
}