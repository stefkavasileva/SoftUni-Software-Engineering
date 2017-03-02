using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Firefighters
{
    static void Main(string[] args)
    {
        int numOfFirefighters = int.Parse(Console.ReadLine());

        int savedKids = 0;
        int savedAdults = 0;
        int savedSeniors = 0;

        string people = Console.ReadLine().ToUpper();

        while (!people.Equals("RAIN"))
        {
            int firefighters = numOfFirefighters;

            if (firefighters > 0)
            {
                int numOfKids = people.Count(x => x.Equals('K'));
                savedKids += numOfKids <= firefighters ? numOfKids : firefighters;
                firefighters -= numOfKids;
            }

            if (firefighters > 0)
            {
                int numOfAdults = people.Count(x => x.Equals('A'));
                savedAdults += numOfAdults <= firefighters ? numOfAdults : firefighters;
                firefighters -= numOfAdults;
            }

            if (firefighters > 0)
            {
                int numOfSeniors = people.Count(x => x.Equals('S'));
                savedSeniors += numOfSeniors <= firefighters ? numOfSeniors : firefighters;
                firefighters -= numOfSeniors;
            }

            people = Console.ReadLine().ToUpper();

        }

        Console.WriteLine("Kids: {0}", savedKids);
        Console.WriteLine("Adults: {0}", savedAdults);
        Console.WriteLine("Seniors: {0}", savedSeniors);
    }
}

