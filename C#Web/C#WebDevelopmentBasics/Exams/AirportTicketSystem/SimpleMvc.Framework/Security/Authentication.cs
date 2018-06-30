namespace SimpleMvc.Framework.Security
{
    public class Authentication
    {
        public Authentication()
        {
            this.IsAuthenticated = false;
        }

        public Authentication(string name)
        {
            this.Name = name;
            this.IsAuthenticated = true;
        }

        public bool IsAuthenticated { get; private set; }

        public string Name { get; private set; }
    }
}
