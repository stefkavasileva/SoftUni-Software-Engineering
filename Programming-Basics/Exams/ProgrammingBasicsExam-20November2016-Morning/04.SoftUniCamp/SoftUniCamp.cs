using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SoftUniCamp
{
    static void Main(string[] args)
    {
        int groups = int.Parse(Console.ReadLine());

        int car = 0;
        int microbus = 0;
        int minibus = 0;
        int bus = 0;
        int train = 0;
        double people = 0;

        for (int i = 0; i < groups; i++)
        {
            int currentPeople = int.Parse(Console.ReadLine());

            if (currentPeople <= 5)
            {
                car += currentPeople;
            }
            else if (currentPeople >= 6 && currentPeople <= 12)
            {
                microbus += currentPeople;
            }
            else if (currentPeople >= 13 && currentPeople <= 25)
            {
                minibus += currentPeople;
            }
            else if (currentPeople >= 26 && currentPeople <= 40)
            {
                bus += currentPeople;
            }
            else
            {
                train += currentPeople;
            }

            people += currentPeople;
        }

        Console.WriteLine("{0:f2}%", (car / people) * 100.0);
        Console.WriteLine("{0:f2}%", (microbus / people) * 100.0);
        Console.WriteLine("{0:f2}%", (minibus / people) * 100.0);
        Console.WriteLine("{0:f2}%", (bus / people) * 100.0);
        Console.WriteLine("{0:f2}%", (train / people) * 100.0);

    }
}

