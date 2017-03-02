using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HousePrice
{
    static void Main(string[] args)
    {
        double smallestRoomArea = double.Parse(Console.ReadLine());
        double kitchenArea = double.Parse(Console.ReadLine());
        decimal price = decimal.Parse(Console.ReadLine());

        double secondRoomArea = smallestRoomArea + (smallestRoomArea * 0.1);
        double thirdRoomArea = secondRoomArea + (secondRoomArea * 0.1);
        double bathroomArea = smallestRoomArea / 2.0;

        double houseArea = smallestRoomArea + kitchenArea + secondRoomArea + thirdRoomArea + bathroomArea;
        houseArea += houseArea * 0.05;

        Console.WriteLine($"{(decimal)houseArea*price:f2}");
    }
}

