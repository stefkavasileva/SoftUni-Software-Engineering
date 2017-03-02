using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Volleyball
{
    static void Main(string[] args)
    {
        string typeOfYear = Console.ReadLine().ToLower();
        int holidays = int.Parse(Console.ReadLine());
        int hometownWeekens = int.Parse(Console.ReadLine());


        double plays = (48 - hometownWeekens) * (3.0 / 4.0) + hometownWeekens + (holidays * 2 / 3.0);

        if (typeOfYear.Equals("leap"))
        {
            plays += plays * 0.15;
        }

        Console.WriteLine((int)plays);

    }
}

