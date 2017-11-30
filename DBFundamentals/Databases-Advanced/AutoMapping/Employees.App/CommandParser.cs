using Employees.App.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace Employees.App
{
    public class CommandParser
    {
        public static ICommand Parse(IServiceProvider serviceProvider, string commandName)
        {
            var commandType = Assembly
                .GetEntryAssembly()
                .GetTypes()
                .Where(t => t.GetInterfaces().Contains(typeof(ICommand)))
                .SingleOrDefault(t => t.Name == $"{commandName}Command");

            if (commandType is null)
            {
                throw new InvalidOperationException();
            }

            var constructor = commandType.GetConstructors().First();
            var constructorArgs = constructor
                .GetParameters()
                .Select(pi => pi.ParameterType)
                .Select(p => serviceProvider.GetService(p))
                .ToArray();

            return (ICommand)constructor.Invoke(constructorArgs);
        }
    }
}
