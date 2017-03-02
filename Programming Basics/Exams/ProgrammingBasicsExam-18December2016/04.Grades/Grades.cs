using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Grades
{
    static void Main(string[] args)
    {
        int students = int.Parse(Console.ReadLine());

        double[] grades = new double[students];

        for (int i = 0; i < students; i++)
        {
            double grade = double.Parse(Console.ReadLine());
            grades[i] = grade;
        }

        double weakPercentage = grades.Count(x => x < 3) * 100.0 / students;
        double goodPercentage = grades.Count(x => x >= 3 && x < 4) * 100.0 / students;
        double veryGoodPercentage = grades.Count(x => x >= 4 && x < 5) * 100.0 / students;
        double exelentPercentage = grades.Count(x => x >= 5 ) * 100.0 / students;
        double average = grades.Average();

        Console.WriteLine($"Top students: {exelentPercentage:f2}%");
        Console.WriteLine($"Between 4.00 and 4.99: {veryGoodPercentage:f2}%");
        Console.WriteLine($"Between 3.00 and 3.99: {goodPercentage:f2}%");
        Console.WriteLine($"Fail: {weakPercentage:f2}%");
        Console.WriteLine($"Average: {average:f2}");

    }
}

