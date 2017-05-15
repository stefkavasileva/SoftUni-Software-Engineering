using System;

namespace _02.UniqueStudentNames
{
    public class StartUp
    {
        public static void Main()
        {
            var studentName = Console.ReadLine();
            while (!studentName.Equals("End"))
            {
                var student = new Student { name = studentName };
                StudentGroup.uniqueStudentNames.Add(student.name);
                studentName = Console.ReadLine();
            }

            Console.WriteLine(StudentGroup.uniqueStudentNames.Count);
        }
    }
}
