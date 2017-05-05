using System.Collections.Generic;
using System.IO;
using System.Linq;

public static class IOManager
{
    public static void TraverseDirectory(string path)
    {
        OutputWriter.WriteEmptyLine();
        var initialIdentation = path.Split('\\').Length;
        var subFolders = new Queue<string>();
        subFolders.Enqueue(path);

        while (subFolders.Count() != 0)
        {
            //Dequeue the folder at the start ot the queue
            var currentPath = subFolders.Dequeue();
            var identation = currentPath.Split('\\').Length - initialIdentation;
            
            //Print the folder path
            OutputWriter.WriteMessageOnNewLine(string.Format("{0}{1}",
                   new string('-', identation), currentPath));

            foreach (var directoryPath in Directory.GetDirectories(currentPath))
            {
                //Add all it's subfolders to the end of the queue
                subFolders.Enqueue(directoryPath);
              
            }         
        }
    }
}
