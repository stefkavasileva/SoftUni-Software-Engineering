using System;
using System.Linq;

public class HornetAssault
{
    public static void Main()
    {
        var beehives = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();
        var hornets = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToList();

        long power = hornets.Sum();

        if (beehives.Count == 0)
        {
            Console.WriteLine(string.Join(" ", hornets));
            return;
        }

        if (hornets.Count == 0)
        {
            Console.WriteLine(string.Join(" ", beehives));
            return;
        }

        for (int i = 0; i < beehives.Count; i++)
        {
            var bees = beehives[i];
            if (bees >= power)
            {
                beehives[i] -= power;

                if (hornets.Count > 0)
                {
                    hornets.RemoveAt(0);
                    power = hornets.Sum();
                }
                else
                {
                    break;
                }

                if (beehives[i] <= 0)
                {
                    beehives.RemoveAt(i);
                    i--;
                }
            }
            else
            {
                beehives.RemoveAt(i);
                i--;
            }
        }

        if (beehives.Count > 0)
        {
            Console.WriteLine(string.Join(" ", beehives));
        }
        else
        {
            Console.WriteLine(string.Join(" ", hornets));
        }
    }
}

