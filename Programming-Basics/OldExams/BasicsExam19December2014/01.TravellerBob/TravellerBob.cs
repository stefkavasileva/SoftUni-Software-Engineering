using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TravellerBob
{
    static void Main(string[] args)
    {
        string typeOfYear = Console.ReadLine();
        int contractsInYear = int.Parse(Console.ReadLine());
        int timeWithFamily = int.Parse(Console.ReadLine());

        int contractTravels = 12 * contractsInYear;
        int familyTravels = 4 * timeWithFamily;
        double travelNormalMonth = ((12 - (contractsInYear + timeWithFamily)) * 12) * 3.0 / 5.0;

        double additional = 0;
        if (typeOfYear.Equals("leap"))
        {
            additional = (contractTravels + familyTravels + travelNormalMonth) * 0.05;
        }

        int totalTravels = (int)(contractTravels + familyTravels + travelNormalMonth + additional);

        Console.WriteLine(totalTravels);
    }
}

