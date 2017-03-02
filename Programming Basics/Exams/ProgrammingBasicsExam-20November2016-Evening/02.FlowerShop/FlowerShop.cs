using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FlowerShop
{
    static void Main(string[] args)
    {
        int magnolias = int.Parse(Console.ReadLine());
        int hyacinths = int.Parse(Console.ReadLine());
        int roses = int.Parse(Console.ReadLine());
        int cactuses = int.Parse(Console.ReadLine());
        decimal presentPrice = decimal.Parse(Console.ReadLine());

        decimal magnoliasIncome = magnolias * 3.25m;
        decimal hyacinthsIncome = hyacinths * 4m;
        decimal rosesIncome = roses * 3.50m;
        decimal cactusesIncome = cactuses * 8m;

        decimal totalIncome = magnoliasIncome + hyacinthsIncome + rosesIncome + cactusesIncome;
        totalIncome -= totalIncome * 0.05m;

        if (totalIncome >= presentPrice)
        {
            int remainder = (int)Math.Floor(totalIncome - presentPrice);
            Console.WriteLine($"She is left with {remainder} leva.");
        }
        else
        {
            int remainder = (int)Math.Ceiling(presentPrice - totalIncome);
            Console.WriteLine($"She will have to borrow {remainder} leva.");
        }

    }
}

