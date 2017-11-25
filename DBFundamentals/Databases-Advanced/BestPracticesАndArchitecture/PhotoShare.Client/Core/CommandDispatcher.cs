namespace PhotoShare.Client.Core
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Contracts;

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
                throw new InvalidOperationException($"Command {inputCommand} not valid!");
            }

            var command = (ICommand)Activator.CreateInstance(commandType);

            return command.Execute(commandParameters);
        }
    }
}
