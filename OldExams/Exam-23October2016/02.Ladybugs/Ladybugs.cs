using System;
using System.Linq;

public class Ladybugs
{
    public static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] ladybugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] field = new int[size];

        FillField(size, ladybugIndexes, field);

        string comand = Console.ReadLine();
        while (!comand.Equals("end"))
        {
            string[] comandArgs = comand.Split().ToArray();
            int position = int.Parse(comandArgs[0]);
            string direction = comandArgs[1];
            int lentgth = int.Parse(comandArgs[2]);

            if (position < 0 || position > size - 1 || field[position] != 1)
            {
                comand = Console.ReadLine();
                continue;
            }

            int newPosition = GetNewPosition(direction, lentgth, position);

            if (newPosition < 0 || newPosition >= size)
            {
                field[position] = 0;
                comand = Console.ReadLine();
                continue;
            }

            field[position] = 0;

            while (position < size && position >= 0 && newPosition < size && newPosition >= 0)
            {
                if (field[newPosition] == 0)
                {
                    field[newPosition] = 1;
                    break;
                }
                else
                {
                    newPosition = GetNewPosition(direction, lentgth, newPosition);
                }
            }

            comand = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }

    private static int GetNewPosition(string direction, int lentgth, int newPosition)
    {
        if (direction == "right")
        {
            newPosition += lentgth;
        }
        else
        {
            newPosition -= lentgth;
        }

        return newPosition;
    }

    private static void FillField(int size, int[] ladybugIndexes, int[] field)
    {
        for (int i = 0; i < ladybugIndexes.Length; i++)
        {
            if (ladybugIndexes[i] >= 0 && ladybugIndexes[i] < size)
            {
                field[ladybugIndexes[i]] = 1;
            }
        }
    }
}
