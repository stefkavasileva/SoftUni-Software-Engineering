using System;

public class MultiplyEvensByOdds
{
    public static void Main()
    {
        char[] inputNum = Console.ReadLine().ToCharArray();

        int oddSum = GetOddSum(inputNum);
        int evenSum = GetEvenSum(inputNum);
        int result = MultiplayTwoNum(oddSum, evenSum);

        Console.WriteLine(result);
    }

    private static int MultiplayTwoNum(int oddSum, int evenSum)
    {
        int result = oddSum * evenSum;
        return result;
    }

    private static int GetOddSum(char[] inputNum)
    {
        int oddSum = 0;
        for (int i = 0; i < inputNum.Length; i++)
        {
            int currentNum = (int)char.GetNumericValue(inputNum[i]);
            if (char.IsDigit(inputNum[i]) && currentNum % 2 == 0)
            {
                oddSum += currentNum;
            }
        }

        return oddSum;
    }

    private static int GetEvenSum(char[] inputNum)
    {
        int evenSum = 0;
        for (int i = 0; i < inputNum.Length; i++)
        {
            int currentNum = (int)char.GetNumericValue(inputNum[i]);
            if (char.IsDigit(inputNum[i]) && currentNum % 2 != 0)
            {
                evenSum += currentNum;
            }
        }

        return evenSum;
    }
}
