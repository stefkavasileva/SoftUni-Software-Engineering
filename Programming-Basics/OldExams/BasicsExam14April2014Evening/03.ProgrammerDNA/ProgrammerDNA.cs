using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ProgrammerDNA
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        char startLeter = char.Parse(Console.ReadLine());
        char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };

        int dots = 3;
        int numOfLetters = 1;
        int rows = 0;
        int index = index = Array.IndexOf(letters, startLeter);
        for (int row = 0; row < size; row++)
        {
            if (rows < 4)
            {
                Console.Write(new string('.', dots));

                for (int l = 0; l < numOfLetters; l++)
                {
                    if (index > letters.Length - 1)
                    {
                        index = 0;
                    }

                    Console.Write(letters[index]);
                    index++;

                }

                Console.WriteLine(new string('.', dots));

                dots--;
                numOfLetters += 2;
                rows++;
            }
            else
            {
                if (dots == -1)
                {
                    dots = 1;
                    numOfLetters = 5;
                }
                Console.Write(new string('.', dots));

                for (int l = 0; l < numOfLetters; l++)
                {
                    if (index > letters.Length - 1)
                    {
                        index = 0;
                    }

                    Console.Write(letters[index]);
                    index++;
                }

                Console.WriteLine(new string('.', dots));

                dots++;
                numOfLetters -= 2;
                rows++;
                if (rows == 7)
                {
                    rows = 0;
                    dots = 3;
                    numOfLetters = 1;
                }
            }

        }
    }
}

