using System;
using System.Linq;
using System.Text;

public static class Rectangle
{
    public static void DrowRectangle(int width, int length)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            if (i == 0 || i == length - 1)
            {
                sb.AppendLine($"|{new string('-', width)}|");
                continue;
            }

            sb.AppendLine($"|{new string(' ', width)}|");
        }

        Console.Write(sb);
    }
}

