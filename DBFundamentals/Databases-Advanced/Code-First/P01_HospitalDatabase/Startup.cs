using P01_HospitalDatabase.Data;

namespace P01_HospitalDatabase
{
    public class Startup
    {
        public static void Main()
        {
            using (var db = new HospitalContext())
            {
                db.Database.EnsureCreated();
            }
        }
    }
}
