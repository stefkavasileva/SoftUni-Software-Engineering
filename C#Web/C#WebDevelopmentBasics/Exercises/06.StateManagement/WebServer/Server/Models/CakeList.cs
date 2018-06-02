using System.Collections.Generic;

namespace HTTPServer.Server.Models
{
    public class CakeList
    {
        private readonly List<Cake> cakes;

        public CakeList(Cake cake)
        {
            this.cakes = new List<Cake>();
        }

        private void Add(Cake cake)
        {
            this.cakes.Add(cake);
        }

       
    }
}
