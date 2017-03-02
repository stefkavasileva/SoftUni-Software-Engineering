using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KingOfThieves
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());
        int outerDash = size / 2;
        int sumSymbols = 1;
        for (int i = 1; i <= size; i++)
        {
            if (i >= 1 && i <= (size + 1) / 2)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', outerDash), new string(symbol, sumSymbols));
                outerDash--;
                sumSymbols += 2;
                if (i == (size + 1) / 2)
                {
                    outerDash = 1;
                    sumSymbols -= 4;
                }
            }
            else
            {
                Console.WriteLine("{0}{1}{0}", new string('-', outerDash), new string(symbol, sumSymbols));
                outerDash++;
                sumSymbols -= 2;
            }
        }
    }
}

