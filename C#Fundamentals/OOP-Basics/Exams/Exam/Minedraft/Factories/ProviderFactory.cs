using System;
using System.Collections.Generic;

public class ProviderFactory
{
    public static Provider CreateProvider(List<string> args)
    {
        var type = args[0];
        var id = args[1];
        var energyOutput = double.Parse(args[2]);

        switch (type)
        {
            case "Pressure":
                return new PressureProvider(id, energyOutput);
            case "Solar":
                return new SolarProvider(id, energyOutput);
            default:
                throw new ArgumentException("Invalid provider type.");
        }
    }
}