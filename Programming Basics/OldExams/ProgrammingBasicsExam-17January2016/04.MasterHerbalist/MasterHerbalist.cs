using System;

public class MasterHerbalist
{
    public static void Main()
    {
        int dailyExpenses = int.Parse(Console.ReadLine());
        string informations = Console.ReadLine();
        int herb = 0;
        double gainedPrice = 0;
        int days = 0;

        for (;;)
        {
            if (informations == "Season Over")
            {
                break;
            }

            string[] info = informations.Split(' ');
            int hours = Convert.ToInt32(info[0]);
            string path = info[1].ToUpper();
            int price = Convert.ToInt32(info[2]);

            if (path.Length >= hours)
            {
                for (int i = 0; i < hours; i++)
                {
                    if (path[i] == 'H')
                    {
                        herb++;
                    }
                }
            }
            else
            {
                for (int i = 0; i < path.Length; i++)
                {
                    if (path[i] == 'H')
                    {
                        herb++;
                    }
                }

                int diff = hours - path.Length;

                for (int j = 0; j < diff; j++)
                {
                    if (j == path.Length)
                    {
                        diff -= j;
                        j = 0;
                    }

                    if (path[j] == 'H')
                    {
                        herb++;
                    }

                }
            }

            gainedPrice = gainedPrice + (herb * price);
            herb = 0;

            informations = Console.ReadLine();

            days++;
        }

        double averageEarnings = gainedPrice / days;

        if (averageEarnings >= dailyExpenses)
        {
            Console.WriteLine("Times are good. Extra money per day: {0:F2}.", averageEarnings - dailyExpenses);
        }
        else
        {
            double moneyNeeded = (dailyExpenses * days) - (averageEarnings * days);
            Console.WriteLine("We are in the red. Money needed: {0}.", (int)moneyNeeded);
        }
    }
}
