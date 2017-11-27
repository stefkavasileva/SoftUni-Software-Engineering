using System;
using PhotoShare.Client.Utilities;

namespace PhotoShare.Client.Core.Commands
{
    public class ExitCommand : Command
    {
        public override string Execute(string[] data)
        {
            Environment.Exit(0);
            return Messages.Bye;
        }
    }
}
