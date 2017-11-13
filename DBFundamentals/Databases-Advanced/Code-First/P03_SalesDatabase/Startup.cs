using P03_SalesDatabase.Data;

namespace P03_SalesDatabase
{
    public class Startup
    {
        public static void Main()
        {
            using (var db = new SalesContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
