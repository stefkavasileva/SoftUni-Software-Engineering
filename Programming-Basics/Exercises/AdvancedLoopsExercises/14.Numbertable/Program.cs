using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                int num = row + col + 1;
                if (num > size)
                {
                    Console.Write(2*size-num +" ");
                }
                else
                {
                    Console.Write(num+" ");
                }
            }

            Console.WriteLine();
        }
    }
}

