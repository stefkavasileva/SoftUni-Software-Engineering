using Employees.App.Contracts;
using Employees.Services;

namespace Employees.App.Commands
{
    public class EmployeeInfoCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public EmployeeInfoCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //<employeeId>
        public string Execute(params string[] data)
        {
            var id = int.Parse(data[0]);

            var employee = employeeService.ById(id);

            return $"ID: {id} - {employee.FirstName} {employee.LastName} -  ${employee.Salary:f2}";
        }
    }
}
