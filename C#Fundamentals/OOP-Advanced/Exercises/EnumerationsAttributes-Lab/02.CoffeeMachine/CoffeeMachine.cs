using System;
using System.Collections.Generic;

public class CoffeeMachine : ICoffeeMachine
{
    private int coins;
    private IList<CoffeeType> coffeesSold;

    public CoffeeMachine()
    {
        this.coffeesSold = new List<CoffeeType>();
    }
    public void BuyCoffee(string size, string type)
    {
        var coffeePrice = (int)Enum.Parse(typeof(CoffeePrice), size);
        var typeOfCoffe = (CoffeeType)Enum.Parse(typeof(CoffeeType), type);

        if (coffeePrice <= this.coins)
        {
            this.coffeesSold.Add(typeOfCoffe);
            this.coins = 0;
        }
    }

    public void InsertCoin(string coin)
    {
        var coffeePrice = (Coin)Enum.Parse(typeof(Coin), coin);
        this.coins += (int)coffeePrice;
    }

    public IEnumerable<CoffeeType> CoffeesSold => this.coffeesSold;
}

