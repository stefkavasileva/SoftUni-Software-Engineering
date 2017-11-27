namespace PhotoShare.Client
{
    using Core;
    using Data;

    public class Application
    {
        public static void Main()
        {
            ResetDatabase();

            var commandDispatcher = new CommandDispatcher();
            var engine = new Engine(commandDispatcher);
            engine.Run();
        }

        private static void ResetDatabase()
        {
            using (var db = new PhotoShareContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            }
        }
    }
}
