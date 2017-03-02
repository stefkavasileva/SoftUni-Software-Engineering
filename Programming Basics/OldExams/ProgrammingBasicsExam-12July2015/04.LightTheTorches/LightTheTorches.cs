using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LightTheTorches
{
    static void Main(string[] args)
    {
        int numOfRooms = int.Parse(Console.ReadLine());
        string roomsState = Console.ReadLine().ToUpper();
        int counter = 0;

        char[] rooms = new char[numOfRooms];

        for (int i = 0; i < numOfRooms; i++)
        {
            if (counter > roomsState.Length - 1)
            {
                counter = 0;
            }

            rooms[i] = roomsState[counter];
            counter++;
        }

        int currentIndex = (rooms.Length - 1) / 2;
        int previousIndex = -1;

        for (;;)
        {
            string[] comand = Console.ReadLine().ToUpper().Split().ToArray();

            if (comand[0] == "END")
            {
                break;
            }

            string direction = comand[0];
            int steps = int.Parse(comand[1]);

            if (direction == "LEFT")
            {
                currentIndex = (currentIndex - steps) - 1;

                if (currentIndex < 0)
                {
                    currentIndex = 0;
                }
            }
            else
            {
                currentIndex = (currentIndex + steps) + 1;

                if (currentIndex > rooms.Length - 1)
                {
                    currentIndex = rooms.Length - 1;
                }
            }

            if (previousIndex == currentIndex)
            {
                continue;
            }

            if (rooms[currentIndex] == 'L')
            {
                rooms[currentIndex] = 'D';
            }
            else
            {
                rooms[currentIndex] = 'L';
            }

            previousIndex = currentIndex;
        }

        int darkRooms = 0;

        for (int room = 0; room < rooms.Length; room++)
        {
            if (rooms[room] == 'D')
            {
                darkRooms++;
            }
        }

        int prays = 'D' * darkRooms;

        Console.WriteLine('D' * darkRooms);
    }
}

