using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class EnduranceRally
{
    static void Main(string[] args)
    {
        string[] drivers = Console.ReadLine().Split().ToArray();
        double[] zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
        int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        List<string> results = new List<string>();

        for (int i = 0; i < drivers.Length; i++)
        {
            string driverName = drivers[i];
            double driverFuel = driverName[0];
            int endIndex = -1;

            for (int j = 0; j < zones.Length; j++)
            {
                if (indexes.Contains(j))
                {
                    driverFuel += zones[j];
                }
                else
                {
                    driverFuel -= zones[j];
                }

                if (driverFuel <= 0)
                {
                    endIndex = j;
                    break;
                }
            }

            string result = string.Empty;

            if (driverFuel > 0)
            {
                result = $"{driverName} - fuel left {driverFuel:f2}";
            }
            else
            {
                result = $"{driverName} - reached {endIndex}";
            }

            results.Add(result);
        }

        foreach (var result in results)
        {
            Console.WriteLine(result);
        }
       
    }
}

