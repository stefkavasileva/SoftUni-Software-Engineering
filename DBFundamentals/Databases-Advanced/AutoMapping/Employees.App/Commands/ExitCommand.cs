using Employees.App.Contracts;
using System;

namespace Employees.App.Commands
{
    public class ExitCommand : ICommand
    {
        public string Execute(params string[] data)
        {
            Environment.Exit(0);
            return string.Empty;
        }
    }
}
