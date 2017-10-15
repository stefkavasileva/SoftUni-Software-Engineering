using System;
using BashSoft.Exceptions;
using BashSoft.Repository;
using BashSoft.SimpleJudge;
using BashSoft.StaticData;

namespace BashSoft.IO.Commands
{
    public class PrintFilteredStudentsCommand : Command
    {
        public PrintFilteredStudentsCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) 
            : base(input, data, judge, repository, inputOutputManager)
        {
        }

        private void TryParseParametersForFilterAndTake(string takeCommand, string takeQuantity, string courseName, string filter)
        {
            if (takeCommand.Equals("take"))
            {
                if (takeQuantity.Equals("all"))
                {
                    this.Repository.FilterAndTake(courseName, filter);
                }
                else
                {
                    int studentsToTake;
                    bool hasParsed = int.TryParse(takeQuantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.Repository.FilterAndTake(courseName, filter, studentsToTake);
                    }
                    else
                    {
                        throw new ArgumentException(ExceptionMessages.InvalidTakeQuantityParameter);
                    }
                }
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidTakeCommand);
            }
        }

        public override void Execute()
        {
            if (Data.Length != 5)
            {
                throw new InvalidCommandException(this.Input);
            }

            string courseName = Data[1];
            string filter = Data[2].ToLower();
            string takeCommand = Data[3].ToLower();
            string takeQuantity = Data[4].ToLower();

            this.TryParseParametersForFilterAndTake(takeCommand, takeQuantity, courseName, filter);
        }
    }
}