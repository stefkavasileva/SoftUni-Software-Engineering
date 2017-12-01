using Employees.App.Contracts;
using Employees.Services;

namespace Employees.App.Commands
{
    public class ManagerInfoCommand : ICommand
    {
        private readonly EmployeeService empService;

        public ManagerInfoCommand(EmployeeService empService)
        {
            this.empService = empService;
        }

        public string Execute(params string[] data)
        {
            var employeeId = int.Parse(data[0]);

            return this.empService.GetManagerInfo(employeeId);
        }
    }
}
