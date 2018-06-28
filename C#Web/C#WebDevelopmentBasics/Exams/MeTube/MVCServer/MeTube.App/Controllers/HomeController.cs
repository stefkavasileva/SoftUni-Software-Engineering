using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using MeTube.Models;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Interfaces;

namespace MeTube.App.Controllers
{
    public class HomeController : BaseController
    {
        [HttpGet]
        public IActionResult Index()
        {
            if (this.User.IsAuthenticated)
            {
                List<Tube> tubesDb;

                using (this.Context)
                {
                    tubesDb = this.Context.Tubes.ToList();
                }

                // var tubeCards = tubesDb.All().Select(g => g.ToHtml()).ToList();

                var result = new StringBuilder();

                for (int i = 0; i < tubesDb.Count; i++)
                {
                    if (i % 3 == 0)
                    {
                        result.Append(@"<div class=""card-group col-12 justify-content-center"">");
                    }

                    result.Append($@"<div class=""col-4"">
                                    <img class=""img-thumbnail"" src=""https://www.youtube.com/watch?v={tubesDb[i].YoutubeId}"" />
                                        <div>
                                            <h5>{tubesDb[i].Title}</h5>
                                            <h5>{tubesDb[i].Author}</h5>
                                        </div>
                                    </div>");

                    if (i % 3 == 2 || i == tubesDb.Count - 1)
                    {
                        result.Append("</div>");
                    }
                }

                var userFormat = File.ReadAllText("../../../Views/Home/user.html");

                this.Model.Data["user"] = userFormat;
                this.Model.Data["username"] = this.User.Name;
                this.Model.Data["tubes"] = result.ToString();

                this.Model["guest"] = string.Empty;
                return this.View();
            }

            var index = File.ReadAllText("../../../Views/Home/guest.html");
            this.Model["guest"] = index;
            this.Model["user"] = string.Empty;
            return View();
        }
    }
}
