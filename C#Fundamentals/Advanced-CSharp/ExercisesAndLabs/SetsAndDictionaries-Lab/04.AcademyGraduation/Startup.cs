using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AcademyGraduation
{
    public class Startup
    {
        public static void Main()
        {
            var studentsGrades = new SortedDictionary<string, List<double>>();
            var studentCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < studentCount; i++)
            {
                var studentName = Console.ReadLine();
                var grades = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();

                if (!studentsGrades.ContainsKey(studentName))
                {
                    studentsGrades.Add(studentName, new List<double>());
                }

                studentsGrades[studentName].AddRange(grades);
            }

            foreach (var studentGrades in studentsGrades)
            {
                Console.WriteLine($"{studentGrades.Key} is graduated with {studentGrades.Value.Average()}");
            }
        }
    }
}
