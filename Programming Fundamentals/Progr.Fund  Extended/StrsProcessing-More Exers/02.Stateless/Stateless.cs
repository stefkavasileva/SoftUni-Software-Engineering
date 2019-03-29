using System;

public class Stateless
{
    public static void Main()
    {
        while (true)
        {
            var state = Console.ReadLine();
            if (state.Equals("collapse")) break;
            var function = Console.ReadLine();

            while (function.Length > 0)
            {
                state = state.Replace(function, string.Empty);

                if (function.Length == 1)
                {
                    state = state.Replace(function, string.Empty);
                    break;
                }

                function = function.Substring(1, function.Length - 2);
            }

            state = state.Trim();
            var result = state.Length == 0 ? "(void)" : state;
  
            Console.WriteLine(result);
        }
    }
}
