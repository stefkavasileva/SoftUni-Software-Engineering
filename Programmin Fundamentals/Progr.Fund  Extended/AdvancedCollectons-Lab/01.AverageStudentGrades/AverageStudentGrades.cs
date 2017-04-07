using System;
using System.Collections.Generic;
using System.Linq;

public class AverageStudentGrades
{
    public static void Main()
    {
        var studentCunt = int.Parse(Console.ReadLine());

        var studentAverageGrades = new Dictionary<string, List<double>>();

        for (int i = 0; i < studentCunt; i++)
        {
            var tokens = Console.ReadLine().Split();
            var studentName = tokens.First();
            var studentGrade = double.Parse(tokens.Last());

            if (!studentAverageGrades.ContainsKey(studentName))
            {
                studentAverageGrades.Add(studentName, new List<double>());
            }

            studentAverageGrades[studentName].Add(studentGrade);
        }

        foreach (var student in studentAverageGrades)
        {
            Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(g => $"{g:f2}"))} (avg: {student.Value.Sum() / student.Value.Count:f2})");
        }
    }
}
