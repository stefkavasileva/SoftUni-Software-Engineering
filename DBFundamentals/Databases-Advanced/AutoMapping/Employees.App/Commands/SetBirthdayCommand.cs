using Employees.App.Contracts;
using Employees.Services;
using System;

namespace Employees.App.Commands
{
    public class SetBirthdayCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public SetBirthdayCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //<employeeId> <date: "dd-MM-yyyy"> 
        public string Execute(params string[] data)
        {
            var id = int.Parse(data[0]);
            var date = DateTime.ParseExact(data[1], "dd-MM-yyyy",null);

           var employeeName = employeeService.SetBirthday(id, date);

            return $"{employeeName}'s birthday was set to {data[1]}";
        }
    }
}
