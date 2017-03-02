using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Vacantion
{
    static void Main(string[] args)
    {
        int adults = int.Parse(Console.ReadLine());
        int students = int.Parse(Console.ReadLine());
        int nights = int.Parse(Console.ReadLine());
        string transport = Console.ReadLine().ToLower();

        decimal adultsPrice = 0.0m;
        decimal studentsPrice = 0.0m;

        if (transport.Equals("airplane"))
        {
            adultsPrice = adults * 70.00m;
            studentsPrice = students * 50.00m;
        }
        else if (transport.Equals("boat"))
        {
            adultsPrice = adults * 42.99m;
            studentsPrice = students * 39.99m;
        }
        else if (transport.Equals("bus"))
        {
            adultsPrice = adults * 32.50m;
            studentsPrice = students * 28.50m;
        }
        else
        {
            adultsPrice = adults * 24.99m;
            studentsPrice = students * 14.99m;

            if (students + adults >= 50)
            {
                adultsPrice -= adultsPrice * 0.5m;
                studentsPrice -= studentsPrice * 0.5m;
            }
        }

        decimal hotelPrice = nights * 82.99m;
        decimal totalPrice = (adultsPrice + studentsPrice) * 2 + hotelPrice;
        decimal commission = totalPrice * 0.1m;
        totalPrice += commission;

        Console.WriteLine("{0:f2}", totalPrice);
    }
}

