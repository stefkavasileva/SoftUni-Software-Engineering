using System;

public class TravellerBob
{
    public static void Main()
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
