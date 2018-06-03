using System.Collections.Generic;
using System.Text;

namespace HTTPServer.Server.Models
{
    public class CakeList
    {
        private static List<Cake> cakes = new List<Cake>();

        public static void Add(Cake cake)
        {
            cakes.Add(cake);
        }

        public static string GetCakes()
        {
            var sb = new StringBuilder();
            foreach (var cake in cakes)
            {
                sb.AppendLine($"{cake.Name} ${cake.Price:f2},");
            }

            return sb.ToString().Trim(',');
        }

        public static string GetCakesAsHtml()
        {
            var sb = new StringBuilder();
            cakes.Reverse();
            foreach (var cake in cakes)
            {
                sb.AppendLine($"<div>name:{cake.Name}</div>");
                sb.AppendLine($"<div>price:{cake.Price:f2}</div>");
            }

            return sb.ToString().Trim();

        }
    }
}
