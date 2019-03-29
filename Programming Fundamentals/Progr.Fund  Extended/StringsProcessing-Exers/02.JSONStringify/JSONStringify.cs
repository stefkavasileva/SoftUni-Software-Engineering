using System;
using System.Collections.Generic;
using System.Linq;

public class JSONStringify
{
    public static void Main()
    {
        var inputLine = Console.ReadLine();
        var students = new List<Student>();

        while (!inputLine.Equals("stringify"))
        {
            var tokens = inputLine
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = tokens[0];
            var age = int.Parse(tokens[2]);
            var grades = tokens.Skip(4).Select(t => t.Trim(',')).Select(int.Parse).ToList();

            if (!students.Any(s => s.Name == name))
            {
                var student = new Student { Name = name, Age = age, Grades = new List<int>() };
                student.Grades.AddRange(grades);
                students.Add(student);
            }
            else
            {
                students.Where(s => s.Name == name).First().Grades.AddRange(grades);
            }

            inputLine = Console.ReadLine();
        }
               
        Console.WriteLine($"[{string.Join(",", students)}]");
    }
}

