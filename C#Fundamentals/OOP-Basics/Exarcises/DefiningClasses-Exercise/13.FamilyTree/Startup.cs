using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.FamilyTree
{
    public class Startup
    {
        public static void Main()
        {
            var family = new List<Person>();

            var inputLines = new List<string>();

            var personInfo = Console.ReadLine();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("End"))
            {
                if (inputLine.Contains("-"))
                {
                    inputLines.Add(inputLine);
                    inputLine = Console.ReadLine();
                    continue;
                }

                var personArgs = inputLine.Split().Where(x => x != string.Empty).ToArray();
                var firstName = personArgs[0];
                var lastName = personArgs[1];
                var date = personArgs[2];

                if (!family.Any(p => p.FirstName == firstName && p.LastName == lastName))
                {
                    var person = new Person(firstName, lastName, date);
                    family.Add(person);
                }

                inputLine = Console.ReadLine();
            }

            for (int i = 0; i < inputLines.Count; i++)
            {
                var lineArgs = inputLines[i].Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                var parentInfo = lineArgs[0].Trim();
                var childInfo = lineArgs[1].Trim();
                var parent = new Person();
                var child = new Person();

                parent = AddParentAndChildInfo(parentInfo, family, parent);
                child = AddParentAndChildInfo(childInfo, family, child);

                child.Parents.Add(parent);
                parent.Children.Add(child);
            }

            var personResult = new Person();
            if (!personInfo.Contains("/"))
            {
                var nameInfo = personInfo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                personResult = family.FirstOrDefault(p => p.FirstName == nameInfo[0] && p.LastName == nameInfo[1]);
            }
            else
            {
                personResult = family.FirstOrDefault(p => p.Birthday == personInfo.Trim());
            }

            Console.WriteLine(personResult);
        }

        public static Person AddParentAndChildInfo(string personInfo, List<Person> family, Person person)
        {
            if (personInfo.Contains('/'))
            {
                person = family.FirstOrDefault(p => p.Birthday == personInfo);
            }
            else
            {
                var nameInfo = personInfo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                person = family.FirstOrDefault(p => p.FirstName == nameInfo[0] && p.LastName == nameInfo[1]);
            }

            return person;
        }
    }
}
