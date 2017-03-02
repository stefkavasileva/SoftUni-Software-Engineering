using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Nums
{
    static void Main(string[] args)
    {
        int startNum = int.Parse(Console.ReadLine());
        int endNum = int.Parse(Console.ReadLine());

        for (int n = startNum; n <= endNum; n++)
        {
            double result = 0;
            if (n % 2 == 0)
            {
                result = Math.Sqrt(n);
            }
            else
            {
                result = n * n;
            }

            Console.WriteLine($"{result:f3}");
        }
    }
}

