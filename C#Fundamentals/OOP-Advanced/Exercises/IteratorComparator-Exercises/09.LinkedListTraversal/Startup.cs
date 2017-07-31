using System;

public class Startup
{
    public static void Main()
    {
        CustomLinkedList<int> linkedList = new CustomLinkedList<int>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] cmdArgs = Console.ReadLine().Split();

            switch (cmdArgs[0])
            {
                case "Add":

                    linkedList.AddToEnd(int.Parse(cmdArgs[1]));
                    break;

                case "Remove":

                    linkedList.Remove(int.Parse(cmdArgs[1]));
                    break;
            }
        }

        Console.WriteLine(linkedList.Count);
        Console.WriteLine(string.Join(" ", linkedList));
    }
}

