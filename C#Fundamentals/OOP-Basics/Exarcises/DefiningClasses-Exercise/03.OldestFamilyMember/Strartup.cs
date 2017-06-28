using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new Family();

            var count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);

                var person = new Person(name, age);
                people.AddMember(person);
            }

            var oldestPerson = people.GetOldestMember(people.People);
            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        }
    }
}
