using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MentorGroup
{
    static void Main(string[] args)
    {
        var studentsAttendances = new Dictionary<string, List<DateTime>>();
        var studentsComments = new Dictionary<string, List<string>>();
        ReadStudentsAttendances(studentsAttendances);
        ReadStudentsComments(studentsAttendances, studentsComments);

        studentsAttendances = studentsAttendances.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        foreach (var student in studentsAttendances)
        {
            Console.WriteLine(student.Key);
            Console.WriteLine("Comments:");
            if (studentsComments.ContainsKey(student.Key))
            {
                var comments = studentsComments[student.Key];
                for (int i = 0; i < comments.Count; i++)
                {
                    Console.WriteLine($"- {comments[i]}");
                }
            }

            Console.WriteLine("Dates attended:");

            List<DateTime> dates = student.Value;
            dates = dates.OrderBy(x => x).ToList();

            for (int i = 0; i < dates.Count; i++)
            {
                Console.WriteLine($"-- {dates[i].ToString("dd/MM/yyyy")}");
            }

        }
    }

    private static void ReadStudentsComments(Dictionary<string, List<DateTime>> studentsAttendances, Dictionary<string, List<string>> studentsComments)
    {
        string studentComment = Console.ReadLine();

        while (!studentComment.Equals("end of comments"))
        {
            string[] commentArgs = studentComment.Split('-').ToArray();

            if (!studentsComments.ContainsKey(commentArgs[0]))
            {
                studentsComments.Add(commentArgs[0], new List<string>());
            }

            studentsComments[commentArgs[0]].Add(commentArgs[1]);


            studentComment = Console.ReadLine();
        }
    }

    private static void ReadStudentsAttendances(Dictionary<string, List<DateTime>> studentsAttendances)
    {
        string studentAttendance = Console.ReadLine();
        while (!studentAttendance.Equals("end of dates"))
        {
            string[] datesArgs = studentAttendance.Split(' ').ToArray();
            if (datesArgs.Length < 2)
            {
                if (!studentsAttendances.ContainsKey(datesArgs[0]))
                {
                    studentsAttendances.Add(datesArgs[0], new List<DateTime>());
                }

                studentAttendance = Console.ReadLine();
                continue;
            }
            string[] datesAsStr = datesArgs[1].Split(',').ToArray();

            List<DateTime> dates = new List<DateTime>();

            if (datesArgs.Length > 0)
            {
                for (int i = 0; i < datesAsStr.Length; i++)
                {
                    DateTime currentDate = DateTime.ParseExact(datesAsStr[i], "d/M/yyyy", CultureInfo.InvariantCulture);
                    dates.Add(currentDate);
                }
            }

            if (!studentsAttendances.ContainsKey(datesArgs[0]))
            {
                studentsAttendances.Add(datesArgs[0], dates);
            }
            else
            {
                studentsAttendances[datesArgs[0]].AddRange(dates);
            }

            studentAttendance = Console.ReadLine();
        }
    }
}

