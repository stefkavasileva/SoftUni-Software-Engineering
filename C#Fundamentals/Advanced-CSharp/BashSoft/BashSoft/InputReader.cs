using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public static class InputReader
    {
        private const string endCommand = "quit";

        public static void StartReadingCommands()
        {
            OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
            var input = Console.ReadLine();
            input = input.Trim();

            while (input != endCommand)
            {
                //Interpret comand
                OutputWriter.WriteMessage($"{SessionData.currentPath}> ");
                input = Console.ReadLine();
                input = input.Trim();
            }
        }

        public static void InterpredCommand(string input)
        {
            var data = input.Split();
            var command = data[0];
            switch (command)
            {
                case "open":
                    TryOpenFile(input, data);
                    break;
                case "mkdir":
                    TryCreateDirectory(input, data);
                    break;
                case "ls":
                    TryTraverseFolders(input, data);
                    break;
                case "cmp":
                    TryCompareFiles(input, data);
                    break;
                case "cdRel":
                    TryChangePathRelatively(input, data);
                    break;
                case "cdAbs":
                    TryChangePathAbsolute(input, data);
                    break;
                case "readDb":
                    TryReadDataBaseFromFile(input, data);
                    break;
                case "help":
                    TryGetHelp(input, data);
                    break;
                case "filter":
                    //todo:
                    break;
                case "order":
                    //todo:
                    break;
                case "decOrder":
                    //todo:
                    break;
                case "download":
                    //todo:
                    break;
                case "downloadAsynch":
                    //todo:
                    break;
                default:
                    DisplayInvalidCommandMessage(input);
                    break;

            }
        }

        private static void DisplayInvalidCommandMessage(string input)
        {
            OutputWriter.DisplayException($"The command '{input}' is invalid");
        }

        private static void TryGetHelp(string input, string[] data)
        {
            throw new NotImplementedException();
        }

        private static void TryReadDataBaseFromFile(string input, string[] data)
        {
            throw new NotImplementedException();
        }

        private static void TryChangePathAbsolute(string input, string[] data)
        {
            throw new NotImplementedException();
        }

        private static void TryChangePathRelatively(string input, string[] data)
        {
            throw new NotImplementedException();
        }

        private static void TryCompareFiles(string intput, string[] data)
        {
            throw new NotImplementedException();
        }

        private static void TryTraverseFolders(string input, string[] data)
        {
            if (data.Length == 1)
            {
                IOManager.TraverseDirectory(data[1]);
            }
            else if (data.Length == 2)
            {
                int depth;
                var hasParsed = int.TryParse(data[1], out depth);
                if (hasParsed)
                {
                    //IOManager.TraverseDirectory(depth);
                }
            }
        }

        private static void TryCreateDirectory(string input, string[] data)
        {
            var folderName = data[1];
            IOManager.CreateDirectoryInCurrentFolder(folderName);
        }

        private static void TryOpenFile(string input, string[] data)
        {
            var fileName = data[1];
            Process.Start(SessionData.currentPath + "\\" + fileName);
        }
    }
}
