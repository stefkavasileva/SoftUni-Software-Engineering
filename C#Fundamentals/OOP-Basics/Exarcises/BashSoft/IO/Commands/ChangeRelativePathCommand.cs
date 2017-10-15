using BashSoft.Exceptions;
using BashSoft.Repository;
using BashSoft.SimpleJudge;

namespace BashSoft.IO.Commands
{
    public class ChangeRelativePathCommand : Command
    {
        public ChangeRelativePathCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) 
            : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (Data.Length != 2)
            {
               throw new InvalidCommandException(this.Input);
            }

            string relPath = Data[1];
            this.InputOutputManager.ChangeCurrentDirectoryRelative(relPath);
        }
    }
}