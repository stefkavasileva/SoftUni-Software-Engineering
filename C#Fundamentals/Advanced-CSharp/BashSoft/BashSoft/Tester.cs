using System;
using System.IO;

namespace BashSoft
{
    public static class Tester
    {
        public static void CompareContent(string userOutputPath, string expectedOutputPath)
        {
            OutputWriter.WriteMessageOnNewLine("Reading files...");

            var mismatchesPath = GetMismatchPath(expectedOutputPath);

            var actualOutputLines = File.ReadAllLines(userOutputPath);
            var expectedOutputLine = File.ReadAllLines(expectedOutputPath);

            bool hasMismatches;
            var mismatches = GetLineWithPossibleMismatches(actualOutputLines, expectedOutputLine, out hasMismatches);

            Printoutput(mismatches, hasMismatches, mismatchesPath);
            OutputWriter.WriteMessageOnNewLine("Files read!");
        }

        private static void Printoutput(string[] mismatches, bool hasMismatch, string mismatchesPath)
        {
            if (hasMismatch)
            {
                foreach (var mismatch in mismatches)
                {
                    OutputWriter.WriteMessageOnNewLine(mismatch);
                }

                File.WriteAllLines(mismatchesPath,mismatches);
                return;
            }

            OutputWriter.WriteMessageOnNewLine("Files are identical. There are no mismatches.");
        }

        private static string[] GetLineWithPossibleMismatches(string[] actualOutputLines, string[] expectedOutputLine, out bool hasMismatches)
        {
            hasMismatches = false;
            var output = string.Empty;

            var mismatches = new string[actualOutputLines.Length];
            OutputWriter.WriteMessageOnNewLine("Comparing files...");

            for (int index = 0; index < actualOutputLines.Length; index++)
            {
                var actualLine = actualOutputLines[index];
                var expectedLine = expectedOutputLine[index];

                if (!actualLine.Equals(expectedLine))
                {
                    output = $"Mismatch at line {index} \"{expectedLine}\", actual: \"{actualLine}\"";
                    output += Environment.NewLine;
                    hasMismatches = true;
                }
                else
                {
                    output = actualLine;
                    output += Environment.NewLine;
                }

                mismatches[index] = output;
            }

            return mismatches;
        }

        private static string GetMismatchPath(string expectedOutputPath)
        {
            var indexOf = expectedOutputPath.IndexOf('\\');
            var directoryPath = expectedOutputPath.Substring(0, indexOf);
            var finalPath = directoryPath + @"\Mismatches.txt";
            return finalPath;
        }
    }
}
