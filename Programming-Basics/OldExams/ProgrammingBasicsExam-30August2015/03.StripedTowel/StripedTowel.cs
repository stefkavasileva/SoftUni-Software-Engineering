using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class StripedTowel
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string elements = "#..";
        int count = 0;
        for (int i = 1; i <= 1.5 * n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (count > elements.Length - 1)
                {
                    count = 0;
                }

                char symbol = elements[count];
                count++;

                Console.Write(symbol);
            }

            Console.WriteLine();
        }
    }
}

