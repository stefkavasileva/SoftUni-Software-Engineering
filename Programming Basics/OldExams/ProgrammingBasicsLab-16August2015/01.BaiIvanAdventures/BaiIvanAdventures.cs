using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BaiIvanAdventures
{
    static void Main(string[] args)
    {
        int currentDayOfWeek = int.Parse(Console.ReadLine());
        decimal money = decimal.Parse(Console.ReadLine());
        decimal wantedAlcohol = decimal.Parse(Console.ReadLine());

        decimal alcoholInL = 0;

        switch (currentDayOfWeek)
        {
            case 0: alcoholInL = money / 25.0m; break;
            case 1: alcoholInL = money / 21.0m; break;
            case 2: alcoholInL = money / 14.0m; break;
            case 3: alcoholInL = money / 17.0m; break;
            case 4: alcoholInL = money / 45.0m; break;
            case 5: alcoholInL = money / 59.0m; break;
            case 6: alcoholInL = money / 42.0m; break;
            default: alcoholInL = 0; break;
        }

        string condition = string.Empty;

        if (alcoholInL > 1.5m)
        {
            condition = "very drunk";
        }
        else if (alcoholInL >= 1.0m)
        {
            condition = "drunk";
        }
        else
        {
            condition = "sober";
        }

        if (alcoholInL > wantedAlcohol)
        {
            Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:f2} l. of alcohol with his friends",
                condition, alcoholInL - wantedAlcohol);
        }
        else if (alcoholInL == wantedAlcohol)
        {
            Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
        }
        else
        {
            Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:f2} l. of alcohol",
                condition, wantedAlcohol - alcoholInL);
        }

    }
}

