namespace _08.MentorGroup
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class MentorGroup
    {
        public static void Main()
        {
            var students = new List<Student>();

            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("end of dates"))
            {
                var studentsActivities = inputLine.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

                var studentName = studentsActivities[0];
                var dates = studentsActivities
                    .Skip(1)
                    .Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture))
                    .ToList();

                if (students.Any(x => x.Name == studentName))
                {
                    var existingStudent = students.Where(x => x.Name == studentName).First();
                    existingStudent.DatesActivities.AddRange(dates);
                }
                else
                {
                    var student = new Student(studentName, new List<string>(), dates);
                    students.Add(student);
                }
              
                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (!inputLine.Equals("end of comments"))
            {
                var studentComment = inputLine.Split('-');
                var studentName = studentComment[0];
                var comment = studentComment[1];

                if (students.Any(x => x.Name == studentName))
                {
                    var existingStudent = students.Where(x => x.Name == studentName).First();
                    existingStudent.Comments.Add(comment);
                }

                inputLine = Console.ReadLine();
            }

            students = students
                .OrderBy(x => x.Name)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (var comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in student.DatesActivities.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {date.ToString("dd/MM/yyyy")}");
                }
            }
        }
    }
}
