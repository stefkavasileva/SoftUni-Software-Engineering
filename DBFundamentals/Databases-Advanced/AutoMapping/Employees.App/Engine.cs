using System;
using System.Linq;

namespace Employees.App
{
    public class Engine
    {
        private readonly IServiceProvider serviceProvider;

        public Engine(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public void Run()
        {
            while (true)
            {
                var input = Console.ReadLine();
                var args = input.Split();
                var commandName = args[0];
                args = args.Skip(1).ToArray();

                var command = CommandParser.Parse(serviceProvider, commandName);
                var result = command.Execute(args);
                Console.WriteLine(result);
            }
        }
    }
}
