using System;

public class Startup
{
    public static void Main()
    {
        //75/100
        var pizza = new Pizza();
        var dough = new Dough();

        var inputLine = Console.ReadLine();

        if (inputLine.Contains("Dough"))
        {
            var tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var type = tokens[1];
            var tech = tokens[2];
            var weight = double.Parse(tokens[3]);

            try
            {
                dough = new Dough(type, tech, weight);
                Console.WriteLine($"{dough.CalcCalories():f2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            inputLine = Console.ReadLine();
            if (inputLine.Equals("END")) return;
        }

        if (inputLine.Contains("Topping"))
        {
            var tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var toppingName = tokens[1];
            var toppingWeight = double.Parse(tokens[2]);

            try
            {
                var topping = new Topping(toppingName, toppingWeight);
                Console.WriteLine($"{topping.CalcCalories():f2}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            return;
        }


        while (!inputLine.Equals("END"))
        {
            var tokens = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (tokens[0].Equals("Pizza"))
            {
                var name = tokens[1];
                var toppingCount = int.Parse(tokens[2]);

                try
                {
                    pizza = new Pizza(name, toppingCount);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
            else if (tokens[0].Equals("Dough"))
            {
                var type = tokens[1];
                var tech = tokens[2];
                var weight = double.Parse(tokens[3]);

                try
                {
                    dough = new Dough(type, tech, weight);
                    pizza.Dough = dough;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }
            }
            else
            {
                var toppingName = tokens[1];
                var toppingWeight = double.Parse(tokens[2]);

                try
                {
                    var topping = new Topping(toppingName, toppingWeight);
                    pizza.Toppings.Add(topping);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }

            }

            inputLine = Console.ReadLine();
        }

        Console.WriteLine($"{pizza.Name} – {pizza.CalcCalories():f2} Calories.");
    }
}


