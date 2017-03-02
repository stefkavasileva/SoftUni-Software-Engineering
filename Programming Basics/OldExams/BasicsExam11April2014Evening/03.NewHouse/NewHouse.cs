using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NewHouse
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int dashes = n / 2;
        int asterisks = 1;

        for (int i = 0; i <= n / 2; i++)
        {
            Console.WriteLine("{0}{1}{0}",
                new string('-', dashes),
                new string('*', asterisks));

            dashes--;
            asterisks += 2;
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|{0}|",
                new string('*', n - 2));
        }
    }
}
