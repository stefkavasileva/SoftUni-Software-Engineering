using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TriangleOfDollars
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int row = 1; row <= n; row++)
        {
            for (int col = 0; col < row; col++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine();
        }
    }
}

