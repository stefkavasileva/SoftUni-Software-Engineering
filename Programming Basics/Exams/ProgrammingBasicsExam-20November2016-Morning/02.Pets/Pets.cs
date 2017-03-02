using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Pets
{
    static void Main(string[] args)
    {

        int days = int.Parse(Console.ReadLine());
        int neededFoodInKg = int.Parse(Console.ReadLine());

        double dogFoodKg = double.Parse(Console.ReadLine());
        double catFoodKg = double.Parse(Console.ReadLine());
        double turtleFoodKg = double.Parse(Console.ReadLine());

        double dogFood = days * dogFoodKg;
        double catFood = days * catFoodKg;
        double turtleFood = (days * turtleFoodKg) / 1000.0;

        double totalKg = catFood + dogFood + turtleFood;

        if (totalKg <= neededFoodInKg)
        {
            double foodLeft = neededFoodInKg - totalKg;
            Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLeft));
        }
        else
        {

            Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(totalKg - neededFoodInKg));
        }
    }
}

