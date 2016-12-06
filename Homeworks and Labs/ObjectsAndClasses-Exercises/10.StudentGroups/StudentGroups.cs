using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime RegistrationDate { get; set; }
}
public class Town
{
    public string Name { get; set; }
    public int SeatsCount { get; set; }
    public List<Student> Students { get; set; }


    public static List<Town> ReadTownsAndStudents()
    {
        List<Town> towns = new List<Town>();

        string inputLine = Console.ReadLine();

        while (!inputLine.Equals("End"))
        {
            if (inputLine.Contains("=>"))
            {
                Town town = new Town();
                string[] townArgs = inputLine
                    .Split(new char[] { ' ', '=', '>' },
                    StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string townName = string.Empty;

                if (townArgs.Length > 3)
                {
                    townName = townArgs[0]+" "+townArgs[1];
                }
                else
                {
                    townName = townArgs[0];
                }

                int seatsCount = int.Parse(townArgs[townArgs.Length - 2]);

                town.Name = townName;
                town.SeatsCount = seatsCount;
                town.Students = new List<Student>();
                towns.Add(town);
            }
            else
            {
                Student student = new Student();
                string[] studentArgs = inputLine.Split('|').ToArray();

                string studentName = studentArgs[0];
                string studentEmail = studentArgs[1].Trim();
                DateTime regDate = DateTime.ParseExact(studentArgs[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);
                student.Name = studentName;
                student.Email = studentEmail;
                student.RegistrationDate = regDate;
                towns.Last().Students.Add(student);

            }


            inputLine = Console.ReadLine();
        }

        return towns;

    }
}

public class Group
{
    public Town Town { get; set; }
    public List<Student> Students { get; set; }

    public static List<Group> DistributeStudentsIntoGroup(List<Town> towns)
    {
        List<Group> groups = new List<Group>();

        towns = towns.OrderBy(x => x.Name).ToList();

        foreach (var town in towns)
        {
            var studentsInTown = town.Students
                 .OrderBy(x => x.RegistrationDate)
                 .ThenBy(x => x.Name)
                 .ThenBy(x => x.Email)
                 .ToList();

            while (studentsInTown.Any())
            {
                var group = new Group();
                group.Town = town;
                group.Students = studentsInTown.Take(group.Town.SeatsCount).ToList();
                studentsInTown = studentsInTown.Skip(group.Town.SeatsCount).ToList();
                groups.Add(group);
            }
        }

        return groups;
    }
}
class StudentGroups
{
    static void Main(string[] args)
    {
        List<Town> towns = Town.ReadTownsAndStudents();
        List<Group> groups = Group.DistributeStudentsIntoGroup(towns);

        PrintGroups(groups, towns);
    }

    private static void PrintGroups(List<Group> groups, List<Town> towns)
    {
        Console.WriteLine($"Created {groups.Count} groups in {towns.Distinct().Count()} towns:");

        foreach (var group in groups.OrderBy(x => x.Town.Name))
        {
            List<string> emails = group.Students.Select(x => x.Email).ToList();
            Console.Write($"{group.Town.Name} => ");
            Console.WriteLine(string.Join(", ", emails));
        }
    }
}



