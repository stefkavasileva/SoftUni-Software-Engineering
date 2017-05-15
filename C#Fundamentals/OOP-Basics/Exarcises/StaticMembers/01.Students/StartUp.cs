using System;

namespace _01.Students
{
    public class StartUp
    {
        public static void Main()
        {
            var studentName = Console.ReadLine();
            while (!studentName.Equals("End"))
            {
                var sudent = new Student(studentName);
                studentName = Console.ReadLine();
            }

            Console.WriteLine(Student.studentCount);
        }
    }
}
