using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.WeakStudents
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

            var result = studentsGroup.Where(x => x.Where(g => g == "3").Count() + x.Where(g => g == "2").Count() >= 2);

            foreach (var student in result)
            {
                Console.WriteLine($"{student[0]} {student[1]}");
            }
        }
    }
}
