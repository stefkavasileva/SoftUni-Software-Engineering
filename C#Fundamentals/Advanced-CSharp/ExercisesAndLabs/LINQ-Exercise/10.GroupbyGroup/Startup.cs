using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.GroupbyGroup
{
    public class Person
    {
        public string Name { get; set; }

        public int Group { get; set; }
    }

    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var studentsGroup = new List<Person>();

            while (!inputLine.Equals("END"))
            {
                var studentNames = inputLine.Trim().Split();
                var studentName = studentNames[0] + " " + studentNames[1];
                var group = int.Parse(studentNames[2]);

                if (!studentsGroup.Any(x => x.Name == studentName))
                {
                    var student = new Person()
                    {
                        Name = studentName,
                        Group = group
                    };

                    studentsGroup.Add(student);
                }

                inputLine = Console.ReadLine();
            }

            var groups = studentsGroup.GroupBy(person => person.Group, person => person.Name);

            foreach (var group in groups.OrderBy(g => g.Key))
            {
                Console.WriteLine($"{group.Key} - {string.Join(", ", group)}");
            }
        }
    }
}
