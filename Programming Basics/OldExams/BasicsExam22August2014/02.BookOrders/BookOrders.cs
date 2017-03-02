using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class BookOrders
{
    static void Main(string[] args)
    {
        int numberOfOrder = int.Parse(Console.ReadLine());
        int totalBook = 0;
        decimal totalPrice = 0.0m;
        for (int i = 0; i < numberOfOrder; i++)
        {
            int numberOfPackets = int.Parse(Console.ReadLine());
            int bookPerPacket = int.Parse(Console.ReadLine());
            decimal bookPrice = decimal.Parse(Console.ReadLine());
            int books = numberOfPackets * bookPerPacket;

            decimal discount = 0;
            if (numberOfPackets >= 10 && numberOfPackets < 110)
            {
                decimal procent = 0.05m;
                for (int j = 10; j < 109; j += 10)
                {
                    if (numberOfPackets >= j && numberOfPackets < j + 10)
                    {
                        discount = bookPrice * procent;
                        break;
                    }
                    procent = procent + 0.01m;
                }
            }
            else if (numberOfPackets >= 110)
            {
                discount = bookPrice * 0.15m;
            }
            bookPrice = bookPrice - discount;
            totalPrice += bookPrice * books;
            totalBook += books;
        }
        Console.WriteLine(totalBook);
        Console.WriteLine("{0:f2}", totalPrice);
    }
}

