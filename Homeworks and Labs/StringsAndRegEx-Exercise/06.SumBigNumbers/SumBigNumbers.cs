using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumBigNumbers
{
    static void Main(string[] args)
    {
        string fistNum = Console.ReadLine().Trim();
        string secondNum = Console.ReadLine().Trim();

         string result = CalcSumOfTwoNums(fistNum, secondNum);
        Console.WriteLine(result);
    }

    private static string CalcSumOfTwoNums(string fistNum, string secondNum)
    {
        int maxLen = Math.Max(fistNum.Length, secondNum.Length);
        fistNum = fistNum.PadLeft(maxLen + 1, '0');
        secondNum = secondNum.PadLeft(maxLen + 1, '0');

        int[] arr1 = fistNum.Select(x => int.Parse(x.ToString())).ToArray();
        int[] arr2 = secondNum.Select(x => int.Parse(x.ToString())).ToArray();
        int[] sum = new int[arr1.Length];

        int carry = 0;
        for (int i = sum.Length - 1; i >= 0; i--)
        {
            int total = arr1[i] + arr2[i] + carry;
            sum[i] = total % 10;
            if (total > 9) carry = 1;
            else carry = 0;
        }
        return string.Join("", sum.SkipWhile(x => x == 0));
    }
}
