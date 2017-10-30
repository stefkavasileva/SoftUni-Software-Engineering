using System;

public class Startup
{
    public static void Main()
    {
        //92/100
        try
        {
            var pizzaInfo = Console.ReadLine().Split();
            var pizzaName = pizzaInfo[1];

            var doughInfo = Console.ReadLine().Split();

            Dough dough = new Dough(doughInfo[1], doughInfo[2], double.Parse(doughInfo[3]));
            Pizza pizza = new Pizza(pizzaName, dough);

            var toppingInfo = Console.ReadLine();
            while (!toppingInfo.Equals("END"))
            {
                var args = toppingInfo.Split();

                var topping = new Topping(args[1], double.Parse(args[2]));
                pizza.AddTopping(topping);

                toppingInfo = Console.ReadLine();
            }

            Console.WriteLine($"{pizza.Name} - {pizza.CalcTotalCalories():F2} Calories.");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}


