using System;
using System.Linq;

public class Nilapdromes
{
    public static void Main()
    {
        //70/100
        var inputLine = Console.ReadLine();
        while (!inputLine.Equals("end"))
        {
            var leftPart = inputLine.Substring(0, inputLine.Length / 2);
            var rightPart = new string(inputLine.Substring(inputLine.Length / 2 + 1).ToArray());

            var indexRight = rightPart.IndexOf(leftPart.Substring(0, 1));
            var indexLeft = leftPart.IndexOf(rightPart.Substring(rightPart.Length - 1));

            if (indexRight != -1 && indexLeft != -1)
            {
                var borderLeft = leftPart.Substring(0, indexLeft + 1);
                var borderRight = rightPart.Substring(rightPart.Length - borderLeft.Length);

                if (borderLeft == borderRight)
                {
                    var core = inputLine.Substring(indexLeft + 1, inputLine.Length - (2 * borderRight.Length));
                    Console.WriteLine(core + borderRight + core);
                }
            }

            inputLine = Console.ReadLine();
        }
    }
}

