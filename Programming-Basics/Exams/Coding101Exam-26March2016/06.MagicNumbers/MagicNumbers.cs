using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MagicNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<string> magicNums = new List<string>();

        for (int i = 111111; i <= 999999; i++)
        {
            int digit1 = (i / 100000) % 10;
            int digit2 = (i / 10000) % 10;
            int digit3 = (i / 1000) % 10;
            int digit4 = (i / 100) % 10;
            int digit5 = (i / 10) % 10;
            int digit6 = i % 10;

            if (digit1 > n || digit2 > n || digit3 > n || digit4 > n || digit5 > n || digit6 > n)
            {
                continue;
            }

            if (digit1 * digit2 * digit3 * digit4 * digit5 * digit6 == n)
            {
                magicNums.Add(digit1.ToString() + digit2 + digit3 + digit4 + digit5 + digit6);
            }
        }

        Console.WriteLine(string.Join(" ", magicNums));
    }
}

