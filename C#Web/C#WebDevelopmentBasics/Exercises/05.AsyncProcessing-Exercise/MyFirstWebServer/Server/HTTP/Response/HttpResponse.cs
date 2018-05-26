using MyFirstWebServer.Server.Contracts;
using MyFirstWebServer.Server.Enums;
using MyFirstWebServer.Server.HTTP.Contracts;
using System.Text;

namespace MyFirstWebServer.Server.HTTP.Response
{
    public abstract class HttpResponse : IHttpResponse
    {
        private readonly IView view;

        protected HttpResponse(string redirectUrl)
        {
            this.HeaderCollection = new HttpHeaderCollection();
            this.StatusCode = HttpStatusCode.Found;
            this.AddHeaders("Location", redirectUrl);
        }

        public void AddHeaders(string location, string redirectUrl)
        {
            this.HeaderCollection.Add(new HttpHeader(location, redirectUrl)); //==>> edvali bachka??? 
        }

        protected HttpResponse(HttpStatusCode responseCode, IView view)
        {
            this.HeaderCollection = new HttpHeaderCollection();
            this.view = view;
            this.StatusCode = responseCode;
        }

        public HttpHeaderCollection HeaderCollection { get; set; }

        public HttpStatusCode StatusCode { get; set; }

        public string StatusMessage => this.StatusCode.ToString();

        public string Response
        {
            get
            {
                var response = new StringBuilder();

                response.AppendLine($"HTTP/1.1 {(int)this.StatusCode} {this.StatusMessage}");
                response.AppendLine(this.HeaderCollection.ToString());
                response.AppendLine();
                
                if((int) this.StatusCode < 300 ||(int)this.StatusCode > 400)
                {
                    response.AppendLine(this.view.View());
                }

                return response.ToString();
            }
        }
    }
}
