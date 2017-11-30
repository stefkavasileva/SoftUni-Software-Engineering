using Employees.App.Contracts;
using Employees.Services;
using System;

namespace Employees.App.Commands
{
    public class EmployeePersonalInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public EmployeePersonalInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //<employeeId> 
        public string Execute(params string[] data)
        {
            var id = int.Parse(data[0]);

            var employeeDto = employeeService.PeronalById(id);

            return $"ID: {employeeDto.Id} - {employeeDto.FirstName} {employeeDto.LastName} - ${employeeDto.Salary:f2}{Environment.NewLine}Birthday: {string.Format("dd-MM-yyyy", employeeDto.Birthday)}{Environment.NewLine}Address: {employeeDto.Address}";

        }
    }
}
