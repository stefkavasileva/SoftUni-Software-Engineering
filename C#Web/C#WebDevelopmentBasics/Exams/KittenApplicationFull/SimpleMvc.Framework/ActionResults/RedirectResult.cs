using SimpleMvc.Framework.Interfaces;

namespace SimpleMvc.Framework.ActionResults
{
    public class RedirectResult : IRedirectable
    {
        public RedirectResult(string redirectUrl)
        {
            this.RedirectUrl = redirectUrl;
        }

        public string RedirectUrl { get; }

        public string Invoke()
        {
            return this.RedirectUrl;
        }

    }
}
