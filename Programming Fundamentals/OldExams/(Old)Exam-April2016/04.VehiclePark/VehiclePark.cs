using System;
using System.Collections.Generic;
using System.Linq;

public class VehiclePark
{
    public static void Main()
    {
        List<string> vehicles = Console.ReadLine().Split().ToList();

        List<string> requests = new List<string>();

        string requestsForVehicles = Console.ReadLine();
        while (requestsForVehicles != "End of customers!")
        {
            string[] requestInfo = requestsForVehicles.Split().ToArray();

            string request = requestInfo[0];
            int sits = int.Parse(requestInfo[2]);

            requests.Add(request[0].ToString().ToLower() + sits);

            requestsForVehicles = Console.ReadLine();
        }

        int solds = 0;

        for (int i = 0; i < requests.Count; i++)
        {
            if (vehicles.Contains(requests[i]))
            {
                string product = requests[i];
                int letter = product[0];
                int sits = int.Parse(product.Substring(1, product.Length - 1));
                long sum = letter * sits;
                Console.WriteLine("Yes, sold for {0}$", sum);
                solds++;
                vehicles.Remove(requests[i]);
            }
            else
            {
                Console.WriteLine("No");
                vehicles.Remove(requests[i]);
            }
        }

        Console.Write("Vehicles left: ");

        Console.WriteLine(string.Join(", ", vehicles));

        Console.WriteLine("Vehicles sold: {0}", solds);
    }
}
