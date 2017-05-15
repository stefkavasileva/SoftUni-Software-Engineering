using System;
using System.Collections.Generic;

namespace _12.PrintPeople
{    
    public class StartUp
    {
        public static void Main()
        {
            var people = new List<Person>();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("END"))
            {
                var personInfo = inputLine.Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                var occupation = personInfo[2];

                var person = new Person(name, age, occupation);
                people.Add(person);

                inputLine = Console.ReadLine();
            }

            people.Sort((a, b) => a.CompareTo(b));

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
