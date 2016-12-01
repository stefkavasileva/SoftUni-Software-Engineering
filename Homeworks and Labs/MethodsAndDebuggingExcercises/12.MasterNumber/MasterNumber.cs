using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MasterNumber
{
    static void Main(string[] args)
    {
        int endNumber = int.Parse(Console.ReadLine());

        for (int currentNum = 1; currentNum <= endNumber; currentNum++)
        {
            bool isMasterNum = IsMaterNum(currentNum);

            if (isMasterNum)
            {
                Console.WriteLine(currentNum);
            }
        }
    }

    private static bool IsMaterNum(int currentNum)
    {
        bool isSimetric = IsSimetric(currentNum);
        bool isSumDivisibleBySeven = IsSumDivisibleBySeven(currentNum);
        bool hasEvenDigit = HasEvenDigit(currentNum);

        if (isSimetric && isSumDivisibleBySeven && hasEvenDigit)
        {
            return true;
        }

        return false;
    }

    private static bool HasEvenDigit(int currentNum)
    {
        while (currentNum!=0)
        {
            int lastDigit = currentNum % 10;
            if (lastDigit%2==0)
            {
                return true;
            }

            currentNum /= 10;
        }

        return false;
    }

    private static bool IsSumDivisibleBySeven(int currentNum)
    {
        long sumOfDigits = 0;
        while (currentNum != 0)
        {
            int lastDigit = currentNum % 10;
            sumOfDigits += lastDigit;
            currentNum /= 10;
        }

        if (sumOfDigits % 7 == 0)
        {
            return true;
        }

        return false;
    }

    private static bool IsSimetric(int currentNum)
    {
        bool isSimetetric = true;

        if (currentNum < 9)
        {
            return isSimetetric;
        }
        else
        {
            char[] number = currentNum.ToString().ToCharArray();
            for (int num = 0; num < number.Length / 2; num++)
            {
                if (number[num] != number[number.Length - num - 1])
                {
                    isSimetetric = false;
                    break;
                }
            }
        }

        return isSimetetric;
    }
}

