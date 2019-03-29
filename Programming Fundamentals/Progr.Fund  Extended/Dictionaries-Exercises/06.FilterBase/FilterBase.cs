using System;
using System.Collections.Generic;
using System.Linq;

public class FilterBase
{
    public static void Main()
    {
        var employeesPossitions = new Dictionary<string, string>();
        var employeesAges = new Dictionary<string, int>();
        var employeesSalaries = new Dictionary<string, double>();

        while (true)
        {
            var inputLine = Console.ReadLine();
            if (inputLine.Equals("filter base")) break;

            var employeeArgs = inputLine.Split(" -> ".ToCharArray());
            var name = employeeArgs.First();
            var data = employeeArgs.Last();

            if (data.All(s => char.IsDigit(s)))
            {
                AddAge(employeesAges, name, data);
            }
            else if (data.All(s => char.IsLetter(s)))
            {
                AddPossition(employeesPossitions, name, data);
            }
            else
            {
                AddSalary(employeesSalaries, name, data);
            }
        }

        var dataType = Console.ReadLine();

        if (dataType.Equals("Position"))
        {
            PrintDate(employeesPossitions, dataType);
        }
        else if (dataType.Equals("Salary"))
        {
            PrintDate(employeesSalaries, dataType);
        }
        else
        {
            PrintDate(employeesAges, dataType);
        }
    }

    private static void PrintDate(Dictionary<string, string> employeesData, string dataType)
    {
        foreach (var kvp in employeesData)
        {
            Console.WriteLine($"Name: {kvp.Key}");
            Console.WriteLine($"{dataType}: {kvp.Value}");
            Console.WriteLine("====================");
        }
    }

    private static void PrintDate(Dictionary<string, int> employeesData, string dataType)
    {
        foreach (var kvp in employeesData)
        {
            Console.WriteLine($"Name: {kvp.Key}");
            Console.WriteLine($"{dataType}: {kvp.Value}");
            Console.WriteLine("====================");
        }
    }

    private static void PrintDate(Dictionary<string, double> employeesData, string dataType)
    {
        foreach (var kvp in employeesData)
        {
            Console.WriteLine($"Name: {kvp.Key}");
            Console.WriteLine($"{dataType}: {kvp.Value:f2}");
            Console.WriteLine("====================");
        }
    }

    public static void AddSalary(Dictionary<string, double> employeesSalaries, string name, string data)
    {
        if (employeesSalaries.ContainsKey(name))
        {
            employeesSalaries.Add(name, 0);
        }

        employeesSalaries[name] = double.Parse(data);
    }

    public static void AddPossition(Dictionary<string, string> employeesPossitions, string name, string data)
    {
        if (employeesPossitions.ContainsKey(name))
        {
            employeesPossitions.Add(name, string.Empty);
        }

        employeesPossitions[name] = data;
    }

    public static void AddAge(Dictionary<string, int> employeesAges, string name, string data)
    {
        if (employeesAges.ContainsKey(name))
        {
            employeesAges.Add(name, 0);
        }

        employeesAges[name] = int.Parse(data);
    }
}