using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SerbianUnleashed
{
    static void Main(string[] args)
    {
        string inputLine = Console.ReadLine();
        var venues = new Dictionary<string, Dictionary<string, decimal>>();

        while (!inputLine.ToLower().Equals("end"))
        {

            string[] inputArgs = inputLine.Split('@');
            string singer = string.Empty;
            string venueName = string.Empty;
            decimal totalPrice = 0.0m;

            try
            {

                singer = inputArgs[0];

                if (singer.Substring(singer.Length-1)!=" ")
                {
                    inputLine = Console.ReadLine();
                    continue;
                }

                string[] venueArgs = inputArgs[1].Split();               

                if (venueArgs.Length > 3)
                {
                    for (int i = 0; i < venueArgs.Length-2; i++)
                    {
                        venueName += venueArgs[i] + " ";
                    }   
                }
                else
                {
                    venueName = venueArgs[0];
                }

                decimal ticketPrice = decimal.Parse(venueArgs[venueArgs.Length - 2]);
                int ticketCount = int.Parse(venueArgs[venueArgs.Length - 1]);
                totalPrice = ticketPrice * ticketCount;
            }
            catch (Exception)
            {
                inputLine = Console.ReadLine();
                continue;
            }


            if (!venues.ContainsKey(venueName))
            {
                venues.Add(venueName, new Dictionary<string, decimal>());
            }

            if (!venues[venueName].ContainsKey(singer))
            {
                venues[venueName].Add(singer, totalPrice);
            }
            else
            {
                venues[venueName][singer] += totalPrice;
            }

            inputLine = Console.ReadLine();
        }

        foreach (var town in venues)
        {
            Console.WriteLine(town.Key);
            Dictionary<string, decimal> singer = town.Value.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var s in singer)
            {
                Console.WriteLine("#  {0}-> {1}", s.Key, s.Value);
            }

        }
    }
}

