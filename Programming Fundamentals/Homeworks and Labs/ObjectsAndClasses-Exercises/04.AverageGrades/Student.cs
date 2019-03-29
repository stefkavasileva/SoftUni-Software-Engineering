namespace _04.AverageGrades
{
    using System.Collections.Generic;
    using System.Linq;

    public class Student
    {
        public Student(string name, List<double> grades)
        {
            this.Name = name;
            this.Grades = grades;
        }

        public string Name { get; set; }

        public List<double> Grades { get; set; }

        public double AverageGrade
        {
            get
            {
                return this.Grades.Average();
            }
        }
    }
}