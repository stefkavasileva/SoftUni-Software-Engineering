using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IncreasingElements
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int maxlen = 0;
        int len = 0;
        int previousNum = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());

            if (previousNum < num && i > 0)
            {
                len++;
            }
            else
            {
                len = 1;
            }

            if (len > maxlen)
            {
                maxlen = len;
            }
            previousNum = num;

        }

        Console.WriteLine(maxlen)
    }
}

