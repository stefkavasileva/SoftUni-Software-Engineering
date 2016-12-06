using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FoldAndSum
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k = nums.Length / 4;

        int[] firstKElements = nums.Take(k).Reverse().ToArray();
        int[] lastKElements = nums.Skip(3 * k).Take(k).Reverse().ToArray();

        int[] middleKELements = nums.Skip(k).Take(2 * k).ToArray();
        int[] arrsConcated = firstKElements.Concat(lastKElements).ToArray();

        PrintElements(middleKELements, arrsConcated);
    }

    private static void PrintElements(int[] middleKELements, int[] arrsConcated)
    {
        for (int i = 0; i < middleKELements.Length; i++)
        {
            Console.Write(middleKELements[i] + arrsConcated[i] + " ");
        }
    }
}

