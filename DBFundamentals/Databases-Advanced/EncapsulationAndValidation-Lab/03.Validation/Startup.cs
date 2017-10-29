using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Validation
{
    public class Startup
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();

            try
            {
                for (int i = 0; i < lines; i++)
                {
                    var cmdArgs = Console.ReadLine().Split();
                    var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                    persons.Add(person);
                }

            }
            catch (ArgumentException exception)
            {
                Console.WriteLine(exception.Message);
            }

            persons.OrderBy(p => p.FirstName)
                 .ThenBy(p => p.Age)
                 .ToList()
                 .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
