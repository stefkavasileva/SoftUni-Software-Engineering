using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var departments = new List<Department>();

        var count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            var employeeInfo = Console.ReadLine().Split();
            var employeeName = employeeInfo[0];
            var salary = decimal.Parse(employeeInfo[1]);
            var possition = employeeInfo[2];
            var departmentName = employeeInfo[3];

            if (!departments.Any(d => d.name == departmentName))
            {
                var department = new Department(departmentName);
                departments.Add(department);
            }

            if (!departments.Any(d => d.employees.Any(e => e.Name == employeeName)))
            {
                var employee = new Employee(employeeName, possition, departmentName, salary);
                if (employeeInfo.Length == 6)
                {
                    employee.Email = employeeInfo[4];
                    employee.Age = int.Parse(employeeInfo[5]);
                }
                else if (employeeInfo.Length == 5)
                {
                    if (employeeInfo[4].Contains("@"))
                    {
                        employee.Email = employeeInfo[4];
                    }
                    else
                    {
                        employee.Age = int.Parse(employeeInfo[4]);
                    }
                }

                departments.FirstOrDefault(d => d.name == departmentName).employees.Add(employee);
            }
        }

        var currentDepartment =
            departments
                .OrderByDescending(d => d.employees.Average(e => e.Salary))
                .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {currentDepartment.name}");

        foreach (var employee in currentDepartment.employees.OrderByDescending(e => e.Salary))
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
        }
    }
}


