using BashSoft.Exceptions;
using BashSoft.Repository;
using BashSoft.SimpleJudge;

namespace BashSoft.IO.Commands
{
    public class DropDatabaseCommand : Command
    {
        public DropDatabaseCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) 
            : base(input, data, judge, repository, inputOutputManager)
        {
        }

        public override void Execute()
        {
            if (Data.Length != 1)
            {
                throw new InvalidCommandException(this.Input);
            }

            this.Repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }
    }
}