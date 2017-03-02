using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int factorial = 1;

        for (int i = 1; i <=n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }
}

