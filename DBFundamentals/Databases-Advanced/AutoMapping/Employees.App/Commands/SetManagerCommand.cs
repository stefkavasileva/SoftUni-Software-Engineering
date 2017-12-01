using Employees.App.Contracts;
using Employees.Services;

namespace Employees.App.Commands
{
    public class SetManagerCommand : ICommand
    {
        private readonly EmployeeService empService;

        public SetManagerCommand(EmployeeService empService)
        {
            this.empService = empService;
        }

        public string Execute(params string[] data)
        {
            var employeeId = int.Parse(data[0]);
            var managerId = int.Parse(data[1]);

            this.empService.SetEmployeeManager(employeeId, managerId);

            return $"Employee with ID {employeeId}'s manager is now employee with ID {managerId}.";
        }
    }
}
