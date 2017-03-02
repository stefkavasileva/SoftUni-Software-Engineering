namespace _04AverageGrade
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _04.AverageGrades;

    public class AverageGrades
    {
        public static void Main()
        {
            int studentsCount = int.Parse(Console.ReadLine());

            var students = new List<Student>();

            students = ReadStudents(studentsCount);

            var topStudents = students
                  .Where(x => x.AverageGrade >= 5.00)
                  .OrderBy(x => x.Name)
                  .ThenByDescending(x => x.AverageGrade)
                  .ToList();

            foreach (var student in topStudents)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }

        private static List<Student> ReadStudents(int studentsCount)
        {
            var students = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                var currentStudent = Console.ReadLine().Split();
                var name = currentStudent[0];
                var studentGrades = new List<double>();

                studentGrades.AddRange(currentStudent.Where((x, index) => index > 0).Select(double.Parse));

                var student = new Student(name, studentGrades);

                students.Add(student);
            }

            return students;
        }
    }
}