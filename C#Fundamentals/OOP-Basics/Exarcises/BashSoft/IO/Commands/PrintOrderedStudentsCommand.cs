using System;
using BashSoft.Exceptions;
using BashSoft.Repository;
using BashSoft.SimpleJudge;
using BashSoft.StaticData;

namespace BashSoft.IO.Commands
{
    public class PrintOrderedStudentsCommand : Command
    {
        public PrintOrderedStudentsCommand(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager) 
            : base(input, data, judge, repository, inputOutputManager)
        {
        }

        private void TryParseParametersForOrderAndTake(string orderCommand, string orderQuantity, string courseName, string orderType)
        {
            if (orderCommand.Equals("take"))
            {
                if (orderQuantity.Equals("all"))
                {
                    this.Repository.OrderAndTake(courseName, orderType);
                }
                else
                {
                    int studentsToTake;
                    bool hasParsed = int.TryParse(orderQuantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.Repository.OrderAndTake(courseName, orderType, studentsToTake);
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
            if (this.Data.Length != 5)
            {
                throw new InvalidCommandException(this.Input);
            }

            string courseName = Data[1];
            string orderType = Data[2].ToLower();
            string orderCommand = Data[3].ToLower();
            string orderQuantity = Data[4].ToLower();

            this.TryParseParametersForOrderAndTake(orderCommand, orderQuantity, courseName, orderType);
        }
    }
}