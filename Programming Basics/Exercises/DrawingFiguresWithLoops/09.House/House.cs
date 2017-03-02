using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class House
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int top = 0;
        int bottom = 0;
        int asterisks = 0;
        int dashes = 0;

        if (n % 2 == 0)
        {
            top = n / 2;
            bottom = n / 2;
            asterisks = 2;
            dashes = (n - 2) / 2;
        }
        else
        {
            top = (n + 1) / 2;
            bottom = top - 1;
            asterisks = 1;
            dashes = (n * 1) / 2;
        }


        for (int row = 0; row < top; row++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('-', dashes),
                new string('*', asterisks));
            dashes--;
            asterisks += 2;
        }

        for (int row = 0; row < bottom; row++)
        {
            Console.WriteLine("|{0}|", new string('*', n - 2));
        }
    }
}

