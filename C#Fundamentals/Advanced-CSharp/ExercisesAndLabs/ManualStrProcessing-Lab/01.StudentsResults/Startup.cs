using System;
using System.Linq;
using System.Text;

namespace _01.StudentsResults
{
    public class Startup
    {
        public static void Main()
        {
            var studentsCount = int.Parse(Console.ReadLine());

            var result = new StringBuilder();
            result.AppendLine($"{"Name",-10}|{"CAdv",7}|{"COOP",7}|{"AdvOOP",7}|{"Average",7}|");
            for (int index = 0; index < studentsCount; index++)
            {
                var currentStudentInfo = Console.ReadLine()
                    .Split(new[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                var studentName = currentStudentInfo[0];
                var cadv = double.Parse(currentStudentInfo[1]);
                var coop = double.Parse(currentStudentInfo[2]);
                var advoop = double.Parse(currentStudentInfo[3]);
                var average = (cadv + coop + advoop) / 3;

                result.AppendLine($"{studentName,-10}|{cadv,7:f2}|{coop,7:f2}|{advoop,7:f2}|{average,7:f4}|");
            }

            Console.Write(result);
        }
    }
}
