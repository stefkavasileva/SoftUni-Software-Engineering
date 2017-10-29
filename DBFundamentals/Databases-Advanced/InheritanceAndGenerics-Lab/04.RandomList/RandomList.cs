using System;
using System.Collections.Generic;

public class RandomList : List<string>
{
    private Random rnd;

    public RandomList()
        :base()
    {
        this.rnd = new Random();
    }

    public string RandomString()
    {
        var index = rnd.Next(0, this.Count - 1);
        var str = this[index];
        this.Remove(str);
        return str;
    }
}
