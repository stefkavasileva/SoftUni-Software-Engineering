using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public class InputReader
    {
        private const string endCommand = "quit";

        private CommandInterpreter interpreter;

        public InputReader(CommandInterpreter interpreter)
        {
            this.interpreter = interpreter;
        }

        public void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}" + "> ");
            string input = Console.ReadLine().Trim();

            while (input != endCommand)
            {
                this.interpreter.InterpredCommand(input);
                OutputWriter.WriteMessage($"{SessionData.currentPath}" + "> ");
                input = Console.ReadLine().Trim();
            }
        }
    }
}
