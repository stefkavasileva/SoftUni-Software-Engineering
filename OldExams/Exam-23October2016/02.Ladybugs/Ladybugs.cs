using System;
using System.Linq;

public class Ladybugs
{
    public static void Main()
    {
        var size = int.Parse(Console.ReadLine());
        var indexes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .Where(x => x > -1 && x < size)
            .ToList();

        var field = new int[size];
        indexes.ForEach(x => field[x] = 1);

        var comand = Console.ReadLine();
        while (!comand.ToLower().Equals("end"))
        {
            var comandArgs = comand.Split();
            var index = int.Parse(comandArgs[0]);

            if (!IsInRange(index, size))
            {
                comand = Console.ReadLine();
                continue;
            }

            if (!IsValid(index, field, true))
            {
                comand = Console.ReadLine();
                continue;
            }

            var direction = comandArgs[1];
            var length = int.Parse(comandArgs[2]);

            field[index] = 0;

            while (true)
            {
                var newPosition = direction.Equals("right") ? index += length : index -= length;

                if (IsInRange(newPosition, size))
                {
                    if (IsValid(newPosition, field, false))
                    {
                        field[newPosition] = 1;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            comand = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", field));
    }

    public static bool IsInRange(int index, int size)
    {
        if (index < 0 || index >= size)
        {
            return false;
        }

        return true;
    }

    public static bool IsValid(int index, int[] field, bool isFirstValidation)
    {
        if (field[index] != 1 && isFirstValidation)
        {
            return false;
        }
        else if (field[index] == 1 && !isFirstValidation)
        {
            return false;
        }

        return true;
    }
}