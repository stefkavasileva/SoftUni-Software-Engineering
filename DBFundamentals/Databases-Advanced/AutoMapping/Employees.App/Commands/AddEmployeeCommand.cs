using Employees.App.Contracts;
using Employees.DtoModels;
using Employees.Services;

namespace Employees.App.Commands
{
    public class AddEmployeeCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public AddEmployeeCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //<firstName> <lastName> <salary> 
        public string Execute(params string[] data)
        {
            var firstName = data[0];
            var lastName = data[1];
            var salary = decimal.Parse(data[2]);

            var employeeDto = new EmployeeDto(firstName, lastName, salary);

            employeeService.AddEmployee(employeeDto);

            return $"Employee {firstName} {lastName} was successfully added!";

        }
    }
}
