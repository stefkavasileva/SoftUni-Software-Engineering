using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Numerology
{
    static void Main(string[] args)
    {
        string[] inputLine = Console.ReadLine().Split().ToArray();

        int[] dateInfo = inputLine[0].Split('.').Select(int.Parse).ToArray();
        string username = inputLine[1];

        long birthdaySum = dateInfo[0] * dateInfo[1] * dateInfo[2];

        if (dateInfo[1] % 2 == 1)
        {
            birthdaySum *= birthdaySum;
        }

        for (int i = 0; i < username.Length; i++)
        {
            if (char.IsDigit(username[i]))
            {
                birthdaySum += (int)char.GetNumericValue(username[i]);
            }
            else if (char.IsLower(username[i]))
            {
                birthdaySum += username[i] - 96;
            }
            else if (char.IsUpper(username[i]))
            {
                birthdaySum += (username[i] - 64) * 2;
            }
        }

        long sum = birthdaySum;

        while (sum > 13)
        {
            sum = 0;
            while (birthdaySum != 0)
            {
                int num = (int)(birthdaySum % 10);
                birthdaySum /= 10;
                sum += num;
            }

            birthdaySum = sum;
        }

        Console.WriteLine(sum);

    }
}

