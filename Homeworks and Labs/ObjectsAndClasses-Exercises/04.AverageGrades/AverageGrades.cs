using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AverageGrade { get; set; }
}
class AverageGrades
{
    static void Main(string[] args)
    {
        int numberOfStudents = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();
        ReadStudents(numberOfStudents, students);
        students = students.Where(x => x.AverageGrade >= 5.00)
                                    .OrderBy(x => x.Name)
                                    .ThenByDescending(x => x.AverageGrade)
                                    .ToList();
        PrintTopStudent(students);
    }

    private static void PrintTopStudent(List<Student> students)
    {
        foreach (var s in students)
        {
            Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}");
        }
    }

    private static void ReadStudents(int numberOfStudents, List<Student> students)
    {
        for (int i = 0; i < numberOfStudents; i++)
        {
            string[] studentArgs = Console.ReadLine().Split().ToArray();

            List<double> grades = new List<double>();
            GetStudentGrades(studentArgs, grades);

            Student currentStudent = new Student();
            currentStudent.Name = studentArgs[0];
            currentStudent.Grades = grades;
            currentStudent.AverageGrade = grades.Average();
            students.Add(currentStudent);

        }
    }

    private static void GetStudentGrades(string[] studentArgs, List<double> grades)
    {
        for (int j = 1; j < studentArgs.Length; j++)
        {
            grades.Add(double.Parse(studentArgs[j]));
        }
    }
}

