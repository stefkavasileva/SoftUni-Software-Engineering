using System;
using System.Linq;
using System.Reflection;
using PhotoShare.Client.Core.Contracts;
using PhotoShare.Client.Utilities;

namespace PhotoShare.Client.Core
{
    public class CommandDispatcher
    {
        public string DispatchCommand(string[] commandParameters)
        {
            var inputCommand = $"{commandParameters[0]}Command";

            var commandType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name.Equals(inputCommand, StringComparison.InvariantCultureIgnoreCase));

            if (commandType is null)
            {
                throw new InvalidOperationException(string.Format(ErrorMessages.InvalidCommandName, inputCommand));
            }

            var command = (ICommand)Activator.CreateInstance(commandType);

            return command.Execute(commandParameters);
        }
    }
}
