using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        int endNum = int.Parse(Console.ReadLine());
        int counter = 1;

        for (int row = 1; row <= endNum; row++)
        {
            for (int col = 0; col < row; col++)
            {
                if (counter>endNum)
                {                  
                    return;
                }
                Console.Write(counter+" ");
                counter++;
            }
            Console.WriteLine();
        }
    }
}

