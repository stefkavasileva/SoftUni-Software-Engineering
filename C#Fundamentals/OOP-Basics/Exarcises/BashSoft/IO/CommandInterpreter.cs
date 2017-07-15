using System;
using System.Diagnostics;
using System.IO;

namespace BashSoft
{
    public class CommandInterpreter
    {
        private Tester judge;
        private StudentsRepository repository;
        private IOManager inputoutputManager;

        public CommandInterpreter(Tester judge, StudentsRepository repository, IOManager inputOutputManager)
        {
            this.judge = judge;
            this.repository = repository;
            this.inputoutputManager = inputOutputManager;
        }

        public void InterpredCommand(string input)
        {
            string[] data = input.Split();
            string command = data[0];
            command = command.ToLower();

            try
            {
                this.ParseComand(input, data, command);
            }
            catch (DirectoryNotFoundException exception)
            {
                OutputWriter.DisplayException(exception.Message);
            }
            catch (ArgumentOutOfRangeException exception)
            {
                OutputWriter.DisplayException(exception.Message);
            }
            catch (ArgumentException exception)
            {
                OutputWriter.DisplayException(exception.Message);
            }
            catch (Exception exception)
            {
                OutputWriter.DisplayException(exception.Message);
            }
        }

        private void ParseComand(string input, string[] data, string command)
        {
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
                    TryReadDatabaseFromFile(input, data);
                    break;
                case "help":
                    TryGetHelp(input, data);
                    break;
                case "filter":
                    TryFilterAndTake(input, data);
                    break;
                case "order":
                    TryOrderAndTake(input, data);
                    break;
                case "decOrder":
                    break;
                case "download":
                    break;
                case "downloadAsynch":
                    break;
                case "show":
                    TryShowWantedData(input, data);
                    break;
                case "dropdb":
                    TryDropDb(input, data);
                    break;
                default:
                    DisplayInvalidCommandMessage(input);
                    break;
            }
        }

        private void TryDropDb(string input, string[] data)
        {
            if (data.Length != 1)
            {
                this.DisplayInvalidCommandMessage(input);
                return;
            }

            this.repository.UnloadData();
            OutputWriter.WriteMessageOnNewLine("Database dropped!");
        }

        private void TryOrderAndTake(string input, string[] data)
        {
            if (!IsDataValid(data, 5))
            {
                return;
            }

            var courseName = data[1];
            var comparison = data[2].ToLower();
            var takeCommand = data[3].ToLower();
            var takeQuantity = data[4].ToLower();

            TryParseParametersForOrderAndTake(takeCommand, takeQuantity, courseName, comparison);
        }

        private void TryParseParametersForOrderAndTake(string takeCommand, string takeQuantity, string courseName, string comparison)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    this.repository.OrderAndTake(courseName, comparison, null);
                }
                else
                {
                    int studentsToTake;
                    var hasParsed = int.TryParse(takeQuantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.repository.OrderAndTake(courseName, comparison, studentsToTake);
                    }
                    else
                    {
                        OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidTakeQueryParamter);
                    }
                }
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidTakeQueryParamter);
            }
        }

        private void TryFilterAndTake(string input, string[] data)
        {
            if (!IsDataValid(data, 5))
            {
                return;
            }

            var courseName = data[1];
            var filter = data[2].ToLower();
            var takeCommand = data[3].ToLower();
            var takeQuantity = data[4].ToLower();

            TryParseParametersForFilterAndTake(takeCommand, takeQuantity, courseName, filter);
        }

        private void TryParseParametersForFilterAndTake(string takeCommand, string takeQuantity, string courseName, string filter)
        {
            if (takeCommand == "take")
            {
                if (takeQuantity == "all")
                {
                    this.repository.FilterAndTake(courseName, filter, null);
                }
                else
                {
                    int studentsToTake;
                    var hasParsed = int.TryParse(takeQuantity, out studentsToTake);
                    if (hasParsed)
                    {
                        this.repository.FilterAndTake(courseName, filter, studentsToTake);
                    }
                    else
                    {
                        OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidTakeQueryParamter);
                    }
                }
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine(ExceptionMessages.InvalidTakeQueryParamter);
            }
        }

        private void TryShowWantedData(string input, string[] data)
        {
            if (data.Length == 2)
            {
                var course = data[1];
                this.repository.GetAllStudentsFromCourse(course);
            }
            else if (data.Length == 3)
            {
                var course = data[1];
                var username = data[2];
                this.repository.GetStudentScoresFromCourse(course, username);
            }
            else
            {
                DisplayInvalidCommandMessage(input);
            }

            return;
        }

        private void TryGetHelp(string input, string[] data)
        {
            OutputWriter.WriteMessageOnNewLine($"{new string('_', 100)}");
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "make directory - mkdir: path "));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "traverse directory - ls: depth "));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "comparing files - cmp: path1 path2"));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "change directory - changeDirREl:relative path"));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "change directory - changeDir:absolute path"));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "read students data base - readDb: path"));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "filter {courseName} excelent/average/poor  take 2/5/all students - filterExcelent (the output is written on the console)"));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "order increasing students - order {courseName} ascending/descending take 20/10/all (the output is written on the console)"));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "download file - download: path of file (saved in current directory)"));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "download file asinchronously - downloadAsynch: path of file (save in the current directory)"));
            OutputWriter.WriteMessageOnNewLine(string.Format("|{0, -98}|", "get help – help"));
            OutputWriter.WriteMessageOnNewLine($"{new string('_', 100)}");
            OutputWriter.WriteEmptyLine();
        }

        private void TryReadDatabaseFromFile(string input, string[] data)
        {
            if (!IsDataValid(data, 2))
            {
                return;
            }

            var databasePath = data[1];
            this.repository.LoadData(databasePath);
        }

        private void TryChangePathRelatively(string input, string[] data)
        {
            if (!IsDataValid(data, 2))
            {
                return;
            }

            var relPath = data[1];
            this.inputoutputManager.ChangeCurrentDirectoryRelative(relPath);
        }

        private void TryChangePathAbsolute(string input, string[] data)
        {
            if (!IsDataValid(data, 2))
            {
                return;
            }

            var absPath = data[1];
            this.inputoutputManager.ChangeCurrentDirectoryAbsolute(absPath);
        }

        private void TryCompareFiles(string input, string[] data)
        {
            if (!IsDataValid(data, 3))
            {
                return;
            }

            this.judge.CompareContent(data[1], data[2]);
        }

        private void TryTraverseFolders(string input, string[] data)
        {
            if (data.Length < 2)
            {
                this.inputoutputManager.TraverseDirectory(0);
            }
            else
            {
                int depth;
                var success = int.TryParse(data[1], out depth);
                if (success)
                {
                    this.inputoutputManager.TraverseDirectory(depth);
                }
                else
                {
                    OutputWriter.WriteMessageOnNewLine(ExceptionMessages.UnableToParseNumber);
                }
            }
        }

        private void TryCreateDirectory(string input, string[] data)
        {
            if (!IsDataValid(data, 2))
            {
                return;
            }

            var folderName = data[1];
            this.inputoutputManager.CreateDirectoryInCurrentFolder(folderName);
        }

        private void TryOpenFile(string input, string[] data)
        {
            if (!IsDataValid(data, 2))
            {
                return;
            }

            var filename = data[1];
            Process.Start(SessionData.currentPath + "\\" + filename);
        }

        private bool IsDataValid(string[] data, int neededLength)
        {
            if (data.Length != neededLength)
            {
                DisplayInvalidCommandMessage(string.Join(" ", data));
                return false;
            }

            return true;
        }
        private void DisplayInvalidCommandMessage(string input)
        {
            OutputWriter.WriteMessageOnNewLine($"The command {input} is invalid!");
        }
    }
}
