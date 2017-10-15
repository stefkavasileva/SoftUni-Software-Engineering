using System;
using BashSoft.Exceptions;
using BashSoft.Repository;
using BashSoft.SimpleJudge;

namespace BashSoft.IO.Commands
{
    public abstract class Command
    {
        private string input;
        private string[] data;
        private Tester judge;
        private StudentsRepository repository;
        private IOManager inputOutputManager;

        protected Command(string input, string[] data, Tester judge, StudentsRepository repository, IOManager inputOutputManager)
        {
            this.Input = input;
            this.Data = data;
            this.judge = judge;
            this.repository = repository;
            this.inputOutputManager = inputOutputManager;
        }

        protected string Input
        {
            get => this.input;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this.input = value;
            }
        }

        protected string[] Data
        {
            get => this.data;
            private set
            {
                if (value == null || value.Length == 0)
                {
                    throw new NullReferenceException();
                }

                this.data = value;
            }
        }

        protected Tester Judge => this.judge;

        protected StudentsRepository Repository => this.repository;

        protected IOManager InputOutputManager => this.inputOutputManager;

        public abstract void Execute();
    }
}