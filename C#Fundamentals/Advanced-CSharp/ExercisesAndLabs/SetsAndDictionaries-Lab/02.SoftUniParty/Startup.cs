using System;
using System.Collections.Generic;

namespace _02.SoftUniParty
{
    public class Startup
    {
        public static void Main()
        {
            var vipGuests = new SortedSet<string>();
            var regularGuests = new SortedSet<string>();

            var input = Console.ReadLine();
            while (!input.Equals("PARTY"))
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (!input.Equals("END"))
            {
                if (char.IsDigit(input[0]) && vipGuests.Contains(input))
                {
                    vipGuests.Remove(input);
                }
                else if (!char.IsDigit(input[0]) && regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(regularGuests.Count + vipGuests.Count);
            foreach (var vipGuest in vipGuests)
            {
                Console.WriteLine(vipGuest);
            }

            foreach (var regularGuest in regularGuests)
            {
                Console.WriteLine(regularGuest);
            }
        }
    }
}
