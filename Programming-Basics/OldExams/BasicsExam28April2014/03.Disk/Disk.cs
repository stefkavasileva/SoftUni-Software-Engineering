using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Disk
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int radius = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                int x = (col - (n + 1) / 2);
                int y = (row - (n + 1) / 2);

                if ((x * x) + (y * y) <= radius * radius)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write('.');
                }
            }

            Console.WriteLine();
        }
    }
}

