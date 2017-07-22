using System;

public class Startup
{
    public static void Main()
    {
        var numbers = Console.ReadLine().Split();
        var urls = Console.ReadLine().Split();

        var phone = new Smartphone();
        foreach (var number in numbers)
        {
            Console.WriteLine(phone.Calling(number));
        }

        foreach (var url in urls)
        {
            Console.WriteLine(phone.Browsing(url));
        }
    }
}
