using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SortStudents
{
    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var studentsGroup = new List<string[]>();
            while (!inputLine.Equals("END"))
            {
                var studentNames = inputLine.Trim().Split();
                studentsGroup.Add(studentNames);
                inputLine = Console.ReadLine();
            }

            var result = studentsGroup.OrderBy(x => x[1]).ThenByDescending(x => x[0]);

            foreach (var student in result)
            {
                Console.WriteLine($"{student[0]} {student[1]}");
            }
        }
    }
}
