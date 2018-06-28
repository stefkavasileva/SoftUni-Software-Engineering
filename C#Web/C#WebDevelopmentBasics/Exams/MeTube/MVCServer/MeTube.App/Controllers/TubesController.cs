using System.Linq;
using MeTube.App.Models.BindingModels;
using MeTube.Models;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Interfaces;

namespace MeTube.App.Controllers
{
    public class TubesController : BaseController
    {
        [HttpGet]
        public IActionResult Upload()
        {
            if (!this.User.IsAuthenticated)
            {
                return RedirectToLogin();
            }

            return this.View();
        }

        [HttpPost]
        public IActionResult Upload(TubeUploadBindingModel tube)
        {
            if (!this.User.IsAuthenticated)
            {
                return RedirectToLogin();
            }

            if (!this.IsValidModel(tube))
            {
                this.Model.Data["error"] = this.GetErrorMessageFromInfalidProp(tube);
                return this.View();
            }

            var tubeDb = new Tube
            {
                Author = tube.Author,
                Description = tube.Description,
                Title = tube.Title,
                UploaderId = this.Context.Users.FirstOrDefault(u => u.Username == this.User.Name).Id,
                YoutubeId = tube.YouTubeLink
            };

            using (this.Context)
            {
                this.Context.Tubes.Add(tubeDb);
                this.Context.SaveChanges();
            }

            return RedirectToHome();
        }
    }
}
