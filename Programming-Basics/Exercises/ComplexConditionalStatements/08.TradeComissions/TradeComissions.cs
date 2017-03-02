using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TradeComissions
{
    static void Main(string[] args)
    {
        string town = Console.ReadLine().ToLower();
        decimal sales = decimal.Parse(Console.ReadLine());
        decimal comission = 0;

        if (town == "sofia")
        {
            if (sales > 10000)
            {
                comission = sales * 0.12m;
            }
            else if (sales > 1000)
            {
                comission = sales * 0.08m;
            }
            else if (sales > 500)
            {
                comission = sales * 0.07m;
            }
            else if (sales > 0)
            {
                comission = sales * 0.05m;
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
        }
        else if (town == "varna")
        {
            if (sales > 10000)
            {
                comission = sales * 0.13m;
            }
            else if (sales > 1000)
            {
                comission = sales * 0.1m;
            }
            else if (sales > 500)
            {
                comission = sales * 0.075m;
            }
            else if (sales > 0)
            {
                comission = sales * 0.045m;
            }
            else
            {
                Console.WriteLine("error");
                return;
            }

        }
        else if (town == "plovdiv")
        {
            if (sales > 10000)
            {
                comission = sales * 0.145m;
            }
            else if (sales > 1000)
            {
                comission = sales * 0.12m;
            }
            else if (sales > 500)
            {
                comission = sales * 0.08m;
            }
            else if (sales > 0)
            {
                comission = sales * 0.055m;
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
        }
        else
        {
            Console.WriteLine("error");
            return;
        }

        Console.WriteLine("{0:f2}", comission);
    }
}
