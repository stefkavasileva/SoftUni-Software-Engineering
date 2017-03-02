using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HotelRoom
{
    static void Main(string[] args)
    {

        string month = Console.ReadLine().ToLower();
        int night = int.Parse(Console.ReadLine());

        decimal studioPrice = 0m;
        decimal apartamentPrice = 0m;

        if (month.Equals("may") || month.Equals("october"))
        {
            studioPrice = night * 50m;
            apartamentPrice = night * 65m;

            if (night > 14)
            {
                studioPrice -= studioPrice * 0.3m;
            }
            else if (night > 7)
            {
                studioPrice -= studioPrice * 0.05m;
            }

        }
        else if (month.Equals("june") || month.Equals("september"))
        {
            studioPrice = night * 75.20m;
            apartamentPrice = night * 68.70m;

            if (night > 14)
            {
                studioPrice -= studioPrice * 0.2m;
            }

        }
        else if (month.Equals("july") || month.Equals("august"))
        {
            studioPrice = night * 76m;
            apartamentPrice = night * 77m;
        }

        if (night > 14)
        {
            apartamentPrice -= apartamentPrice * 0.1m;
        }

        Console.WriteLine("Apartment: {0:f2} lv.", apartamentPrice);
        Console.WriteLine("Studio: {0:f2} lv.", studioPrice);

    }
}

