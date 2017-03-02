using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MatchTickets
{
    static void Main(string[] args)
    {
        decimal budget = decimal.Parse(Console.ReadLine());
        string categorie = Console.ReadLine().ToLower();
        int people = int.Parse(Console.ReadLine());

        if (people >= 50)
            budget -= budget * 0.25m;
        else if (people >= 25 && people < 50)
            budget -= budget * 0.4m;
        else if (people >= 10 && people < 24)
            budget -= budget * 0.5m;
        else if (people >= 5 && people < 9)
            budget -= budget * 0.6m;
        else
            budget -= budget * 0.75m;

        if (categorie.Equals("normal"))
            budget -= people * 249.99m;
        else
            budget -= people * 499.99m;

        if (budget > 0)
            Console.WriteLine("Yes! You have {0:f2} leva left.", budget);
        else
            Console.WriteLine("Not enough money! You need {0} leva.", Math.Abs(budget));
    }
}

