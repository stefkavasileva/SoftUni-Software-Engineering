using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DifferentIntegersSize
{
    static void Main(string[] args)
    {
        string inputNum = Console.ReadLine();
        long number = 0;
        
        try
        {
            number = long.Parse(inputNum);
        }
        catch (Exception)
        {

            Console.WriteLine(inputNum+" can't fit in any type");
            return;
        }

        List<string> posibleType = new List<string>();

        posibleType.Add("* long");

        if (number>=uint.MinValue && number<=uint.MaxValue)
        {
            posibleType.Add("* uint");
        }

        if (number >= int.MinValue && number <= int.MaxValue)
        {
            posibleType.Add("* int");
        }

        if (number >= ushort.MinValue && number <= ushort.MaxValue)
        {
            posibleType.Add("* ushort");
        }

        if (number >= short.MinValue && number <= short.MaxValue)
        {
            posibleType.Add("* short");
        }

        if (number >= byte.MinValue && number <= byte.MaxValue)
        {
            posibleType.Add("* byte");
        }

        if (number >= sbyte.MinValue && number <= sbyte.MaxValue)
        {
            posibleType.Add("* sbyte");
        }

        posibleType.Add(inputNum + " can fit in: ");

        posibleType.Reverse();

        Console.WriteLine(string.Join("\n",posibleType));

    }
}

