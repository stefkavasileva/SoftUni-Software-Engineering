using System;
using System.Collections.Generic;
using System.Text;

public class Startup
{
    public static void Main()
    {
        IList<TrafficLightSignal> trafficLights = new List<TrafficLightSignal>();
        var input = Console.ReadLine().Split();

        foreach (string signal in input)
        {
            TrafficLightSignal currentTrafficLight;
            Enum.TryParse(signal, out currentTrafficLight);
            trafficLights.Add(currentTrafficLight);
        }

        var switchesCount = int.Parse(Console.ReadLine());

        var result = new StringBuilder();
        for (int i = 0; i < switchesCount; i++)
        {
            for (int j = 0; j < trafficLights.Count; j++)
            {
                var trafficLight = trafficLights[j];
                trafficLight = SwitchLight(trafficLight);
                trafficLights[j] = trafficLight;
                result.Append($"{trafficLight} ");

            }
            result.AppendLine();
        }

        Console.WriteLine(result.ToString().Trim());
    }

    private static TrafficLightSignal SwitchLight(TrafficLightSignal trafficLight)
    {
        var enumLength = Enum.GetNames(typeof(TrafficLightSignal)).Length;
        var currentIndex = (int)trafficLight;
        trafficLight = (TrafficLightSignal)((currentIndex + 1) % enumLength);
        return trafficLight;
    }
}

