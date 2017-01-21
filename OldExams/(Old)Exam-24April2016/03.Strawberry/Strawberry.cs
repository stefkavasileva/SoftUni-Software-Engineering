using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Strawberry
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int outerDashes = 0;
        int innerdashes = n;

        int totalSize = (2 * n) + 1;
        int topSize = n / 2;
        int bottomSize = n;
        int middleSize = totalSize - topSize - bottomSize;

        for (int i = 0; i < topSize; i++)
        {
            Console.WriteLine("{0}\\{1}|{1}/{0}",
                new string('-', outerDashes),
                new string('-', innerdashes));

            outerDashes += 2;
            innerdashes -= 2;
        }

        outerDashes = n;
        int dots = 1;

        for (int i = 0; i < middleSize; i++)
        {
            if (outerDashes == -1)
            {
                outerDashes = 0;
                dots -= 2;
            }

            Console.WriteLine("{0}#{1}#{0}",
                new string('-', outerDashes),
                new string('.', dots));

            outerDashes -= 2;
            dots += 4;
        }

        outerDashes = 1;
        dots -= 6;

        for (int i = 0; i < bottomSize; i++)
        {
            Console.WriteLine("{0}#{1}#{0}",
                new string('-', outerDashes),
                new string('.', dots));

            outerDashes++;
            dots -= 2;
        }
    }
}
