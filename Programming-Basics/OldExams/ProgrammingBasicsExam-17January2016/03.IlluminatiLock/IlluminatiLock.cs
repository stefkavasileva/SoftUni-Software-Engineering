using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IlluminatiLock
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int outerDots = n - 2;
        int innerDots = 0;
       
        for (int i = 1; i <= n + 1; i++)
        {
            if (i == 1 || i == n + 1)
            {
                Console.WriteLine("{0}{1}{0}", 
                    new string('.', n), 
                    new string('#', n));
            }
            else if (i <= (n - 1) / 2)
            {
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", 
                    new string('.', outerDots), 
                    new string('.', innerDots),
                    new string('.', n - 2));

                outerDots -= 2;
                innerDots += 2;
            }
            else if (i <= ((n + 1) / 2) + 1)
            {
                Console.WriteLine(".##{0}#{1}#{0}##.",
                    new string('.', n - 3), 
                    new string('.', n - 2));
            }
            else
            {
                if (outerDots == 1)
                {
                    outerDots = 3;
                    innerDots = innerDots - 2;
                }

                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", 
                    new string('.', outerDots), 
                    new string('.', innerDots), 
                    new string('.', n - 2));

                outerDots += 2;
                innerDots -= 2;
            }
        }
    }
}

