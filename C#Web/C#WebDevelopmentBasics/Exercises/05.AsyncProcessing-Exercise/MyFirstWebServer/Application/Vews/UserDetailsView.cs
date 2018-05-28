using MyFirstWebServer.Server;
using MyFirstWebServer.Server.Contracts;

namespace MyFirstWebServer.Application.Vews
{
    public class UserDetailsView : IView
    {
        private readonly Model model;

        public UserDetailsView(Model model)
        {
            this.model = model;      
        }

        public string View()
        {
            return $"<body>Hello, {model["name"]}!</body>";
        }
    }
}
