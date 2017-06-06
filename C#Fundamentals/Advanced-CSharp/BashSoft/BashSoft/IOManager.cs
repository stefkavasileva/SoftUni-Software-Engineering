namespace BashSoft
{
    using System.Collections.Generic;
    using System.IO;

    public static class IOManager
    {
        public static void TraverseDirectory(string path)
        {
            OutputWriter.WriteEmptyLine();
            var initialIdentation = SessionData.currentPath.Split('\\').Length;
            var subFolders = new Queue<string>();
            subFolders.Enqueue(SessionData.currentPath);
            var deapt = 0;

            while (subFolders.Count != 0)
            {
                //TODO: Dequeue the folder  at the start of the queue
                var currentPath = subFolders.Dequeue();
                var identation = currentPath.Split('\\').Length - initialIdentation;

                //TODO: Print the folder path
                OutputWriter.WriteMessageOnNewLine($"{new string('-', identation)}{currentPath}");

                //TODO: Add all it's subfolders to the end of the queue

                foreach (var directoryPath in Directory.GetDirectories(currentPath))
                {
                    subFolders.Enqueue(directoryPath);
                }

                foreach (var file in Directory.GetFiles(currentPath))
                {
                    var indexOfLastSlash = file.LastIndexOf("\\");
                    var fileName = file.Substring(indexOfLastSlash);
                    OutputWriter.WriteMessageOnNewLine(new string('-', indexOfLastSlash) + fileName);
                }

                if (deapt - initialIdentation > 0)
                {
                    break;
                }
            }
        }

        public static void CreateDirectoryInCurrentFolder(string name)
        {
            var path = SessionData.currentPath + "\\" + name;
            Directory.CreateDirectory(path);
        }
    }
}
