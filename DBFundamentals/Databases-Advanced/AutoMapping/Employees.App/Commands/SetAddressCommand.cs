using Employees.App.Contracts;
using Employees.Services;
using System.Linq;

namespace Employees.App.Commands
{
    public class SetAddressCommand : ICommand
    {
        private readonly EmployeeService employeeService;

        public SetAddressCommand(EmployeeService employeeService)
        {
            this.employeeService = employeeService;
        }

        //<employeeId> <address> 
        public string Execute(params string[] data)
        {
            var id = int.Parse(data[0]);
            var address = string.Join(" ", data[1].Skip(1));

            var employeeName = employeeService.SetAddress(id, address);

            return $"{employeeName}'s address was set to {data[1]}";
        }
    }
}
