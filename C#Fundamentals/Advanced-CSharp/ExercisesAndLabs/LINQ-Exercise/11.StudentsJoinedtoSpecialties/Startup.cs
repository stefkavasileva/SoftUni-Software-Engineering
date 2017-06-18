using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.StudentsJoinedtoSpecialties
{
    public class StudentSpecialty
    {
        public StudentSpecialty(string name, string number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name { get; set; }
        public string Number { get; set; }
    }

    public class Student
    {
        public Student(string studentName, string facultyName)
        {
            this.StudentName = studentName;
            this.FacultyNumber = facultyName;
        }

        public string StudentName { get; set; }
        public string FacultyNumber { get; set; }
    }
    public class Startup
    {
        public static void Main()
        {
            var specialties = new List<StudentSpecialty>();

            var inputLine = Console.ReadLine();
            while (!inputLine.Equals("Students:"))
            {
                var index = inputLine.LastIndexOf(" ");
                var name = inputLine.Substring(0, index);
                var number = inputLine.Substring(index + 1);

                specialties.Add(new StudentSpecialty(name, number));
                inputLine = Console.ReadLine();
            }

            var students = new List<Student>();
            inputLine = Console.ReadLine();
            while (!inputLine.Equals("END"))
            {
                var index = inputLine.IndexOf(" ");
                var number = inputLine.Substring(0, index);
                var name = inputLine.Substring(index + 1);

                students.Add(new Student(name, number));
                inputLine = Console.ReadLine();
            }

          var result =  specialties.Join(students,
                speciality => speciality.Number,
                student => student.FacultyNumber,
                (speciality, student) => new { student.StudentName, student.FacultyNumber, speciality.Name });

            foreach (var student in result.OrderBy(x=>x.StudentName))
            {
                Console.WriteLine($"{student.StudentName} {student.FacultyNumber} {student.Name}");
            }

        }
    }
}
