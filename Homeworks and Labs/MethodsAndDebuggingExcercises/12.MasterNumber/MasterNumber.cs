using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MasterNumber
{
    static void Main(string[] args)
    {
        int endNum = int.Parse(Console.ReadLine());

        for (int i = 1; i <= endNum; i++)
        {
            bool isMasterNum = IsMasterNumber(i);

            if (isMasterNum)
            {
                Console.WriteLine(i);
            }
        }
    }

    private static bool IsMasterNumber(int i)
    {
        bool isSymetric = IsSymetricNumber(i.ToString());
        bool isSumDevisibleBySeven = CheckSum(i);
        bool hasEvenNum = CheckForEvenNum(i);

        return isSymetric && isSumDevisibleBySeven && hasEvenNum;
    }

    private static bool CheckForEvenNum(int i)
    {
        while (i != 0)
        {
            int lastDigit = i % 10;
            i /= 10;
            if (lastDigit % 2 == 0)
            {
                return true;
            }
        }

        return false;
    }

    private static bool CheckSum(int i)
    {
        int sum = 0;
        while (i != 0)
        {
            int lastDigit = i % 10;
            i /= 10;
            sum += lastDigit;
        }

        return sum % 7 == 0;
    }

    private static bool IsSymetricNumber(string numAsStr)
    {
        bool isSymetric = true;
        for (int i = 0; i < numAsStr.Length / 2; i++)
        {
            if (numAsStr[i] != numAsStr[numAsStr.Length - 1 - i])
            {
                isSymetric = false;
                break;
            }
        }

        return isSymetric;
    }
}

