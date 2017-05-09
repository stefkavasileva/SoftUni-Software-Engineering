using System;
using System.Linq;

public class ListOfPredicates
{
    public static void Main()
    {
        var endNum = int.Parse(Console.ReadLine());
        var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

       var predicates = numbers.Select(div => (Func<int, bool>)(n => n % div == 0)).ToArray();

        for (int j = 1; j <= endNum; j++)
        {
            bool isDivisable = true;

            foreach (var predicate in predicates)
            {
                if (!predicate(j))
                {
                    isDivisable = false;
                    break;
                }
            }

            if (isDivisable)
            {
                Console.Write($"{j} ");
            }
        }
    }
}




