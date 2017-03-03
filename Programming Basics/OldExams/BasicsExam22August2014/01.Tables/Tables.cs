using System;

public class Tables
{
    public static void Main()
    {
        long packet1 = long.Parse(Console.ReadLine());
        long packet2 = long.Parse(Console.ReadLine());
        long packet3 = long.Parse(Console.ReadLine());
        long packet4 = long.Parse(Console.ReadLine());
        long tops = long.Parse(Console.ReadLine());
        long legs = (packet1 * 1) + (packet2 * 2) + (packet3 * 3) + (packet4 * 4);
        long tablesToBeMade = int.Parse(Console.ReadLine());

        long tableMade = Math.Min(legs / 4, tops);

        if (tablesToBeMade < tableMade)
        {
            Console.WriteLine("more: {0}", tableMade - tablesToBeMade);
            Console.WriteLine("tops left: {0}, legs left: {1}", tops - tablesToBeMade, (legs) - (tablesToBeMade * 4));
        }
        else if (tablesToBeMade > tableMade)
        {
            Console.WriteLine("less: {0}", tableMade - tablesToBeMade);

            if (tops < tablesToBeMade && legs < tablesToBeMade * 4)
            {
                Console.WriteLine("tops needed: {0}, legs needed: {1}", tablesToBeMade - tops, (tablesToBeMade * 4) - legs);
            }
            else if (tops >= tablesToBeMade)
            {
                Console.WriteLine("tops needed: 0, legs needed: {0}", (tablesToBeMade * 4) - legs);
            }
            else
            {
                Console.WriteLine("tops needed: {0}, legs needed: 0", tablesToBeMade - tops);
            }
        }
        else
        {
            Console.WriteLine("Just enough tables made: {0}", tableMade);
        }
    }
}