using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ExcellentStudents
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

            var result = studentsGroup.Where(x => x.Contains("6"));

            foreach (var student in result)
            {
                Console.WriteLine($"{student[0]} {student[1]}");
            }
        }
    }
}
