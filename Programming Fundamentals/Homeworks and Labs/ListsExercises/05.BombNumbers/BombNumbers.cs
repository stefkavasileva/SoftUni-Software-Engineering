using System;
using System.Collections.Generic;
using System.Linq;

public class BombNumbers
{
    public static void Main()
    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] bombArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int bombNumber = bombArgs[0];
        int power = bombArgs[1];

        int indexOfBombNum = numbers.IndexOf(bombNumber);

        while (indexOfBombNum != -1)
        {
            int leftPower = indexOfBombNum < power ? indexOfBombNum : power;
            int leftIndex = indexOfBombNum - power < 0 ? 0 : indexOfBombNum - power;
            int rightPower = indexOfBombNum + power > numbers.Count ? numbers.Count - indexOfBombNum - 1 : power;

            numbers.RemoveRange(leftIndex, leftPower + rightPower + 1);
            indexOfBombNum = numbers.IndexOf(bombNumber);
        }

        Console.WriteLine(numbers.Sum());
    }
}