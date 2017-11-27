using PhotoShare.Client.Core.Contracts;

namespace PhotoShare.Client.Core.Commands
{
    public abstract class Command : ICommand
    {
        public abstract string Execute(string[] data);
    }
}
