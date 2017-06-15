using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FilterByAge
{
    public class Startup
    {
        public static void Main()
        {
            var linesCount = int.Parse(Console.ReadLine());
            var people = new Dictionary<string, int>();

            for (int i = 0; i < linesCount; i++)
            {
                var personInfo = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = personInfo[0];
                var personAge = int.Parse(personInfo[1]);

                people.Add(name, personAge);
            }

            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            people = GetByCondition(condition, age, people);
            PrintByFormat(format, people);
        }

        private static void PrintByFormat(string format, Dictionary<string, int> people)
        {
            if (format.Equals("name age"))
            {
                foreach (var person in people)
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }

                return;
            }

            Console.WriteLine(string.Join(Environment.NewLine, format.Equals("name") ? people.Keys.ToList(): people.Values.Select(x=>x.ToString()).ToList())); 
        }

        private static Dictionary<string, int> GetByCondition(string condition, int age, Dictionary<string, int> people)
        {
            return condition.Equals("older") ? people.Where(x => x.Value >= age).ToDictionary(x => x.Key, x => x.Value) : people.Where(x => x.Value < age).ToDictionary(x => x.Key, x => x.Value);
        }
    }
}
