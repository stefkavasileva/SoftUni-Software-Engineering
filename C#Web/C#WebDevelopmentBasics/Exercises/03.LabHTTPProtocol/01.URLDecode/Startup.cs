using System;
using System.Net;

namespace _01.URLDecode
{
    public class Startup
    {
        public static void Main()
        {
            var encodedUrl = Console.ReadLine();
            var decodeUrl = WebUtility.UrlDecode(encodedUrl);

            Console.WriteLine(decodeUrl);
        }
    }
}
