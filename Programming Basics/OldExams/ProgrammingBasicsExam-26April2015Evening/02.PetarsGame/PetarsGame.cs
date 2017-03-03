using System;

public class PetarsGame
{
    public static void Main()
    {
        //90/100
        ulong start = ulong.Parse(Console.ReadLine());
        ulong end = ulong.Parse(Console.ReadLine());
        string replacemantStr = Console.ReadLine();

        ulong sumOfDigit = 0;
        for (ulong i = start; i < end; i++)
        {
            if (i % 5 == 0)
            {
                sumOfDigit += i;
            }
            else
            {
                ulong remainder = (i % 5);
                sumOfDigit += remainder;
            }
        }

        string sumAsStr = sumOfDigit.ToString();

        if (sumOfDigit % 2 == 0)
        {
            int firstDigit = int.Parse(sumAsStr[0].ToString());
            for (ulong i = 0; i < (ulong)sumAsStr.Length; i++)
            {
                int nums = (int)char.GetNumericValue(sumAsStr[(int)i]);
                if (nums == firstDigit)
                {
                    sumAsStr = sumAsStr.Replace(sumAsStr[(int)i].ToString(), replacemantStr);
                }
            }
        }
        else
        {
            int lastDigitAsInt = (int)(sumOfDigit % 10);

            for (ulong i = 0; i < (ulong)sumAsStr.Length; i++)
            {
                int nums = (int)char.GetNumericValue(sumAsStr[(int)i]);
                if (nums == lastDigitAsInt)
                {
                    sumAsStr = sumAsStr.Replace(sumAsStr[(int)i].ToString(), replacemantStr);
                }
            }
        }

        Console.WriteLine(sumAsStr);
    }
}