using System;
using System.Linq;
using System.Text;

public static class Square
{
    public static void DrowSquare(int size)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < size; i++)
        {
            if (i == 0 || i == size - 1)
            {
                sb.AppendLine($"|{new string('-', size)}|");
                continue;
            }

            sb.AppendLine($"|{new string(' ', size)}|");
        }

        Console.Write(sb);
    }
}

