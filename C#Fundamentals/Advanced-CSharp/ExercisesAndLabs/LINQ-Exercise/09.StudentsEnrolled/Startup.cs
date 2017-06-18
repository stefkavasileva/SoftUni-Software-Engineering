using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.StudentsEnrolled
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

            var result = studentsGroup
                .Where(x => x[0].Substring(x[0].Length - 2).Equals("14") 
                || x[0].Substring(x[0].Length - 2).Equals("15"));

            foreach (var student in result)
            {
                Console.WriteLine($"{string.Join(" ", student.Where((x, i) => i > 0))}");
            }
        }
    }
}
