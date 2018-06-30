namespace KittenApp.Web.Controllers
{
    using KittenApp.Models;
    using KittenApp.Web.Models.BindingModels;
    using KittenApp.Web.Models.ViewModels;
    using Microsoft.EntityFrameworkCore;
    using SimpleMvc.Framework.Attributes.Methods;
    using SimpleMvc.Framework.Attributes.Security;
    using SimpleMvc.Framework.Interfaces;
    using System.Linq;
    using System.Text;

    public class KittensController : BaseController
    {
        private const int KittensPerPage = 3;

        [HttpGet]
        [PreAuthorize]
        public IActionResult Add()
        {
            this.Model.Data["error"] = string.Empty;
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(KittenAddingModel model)
        {
            using (this.Context)
            {
                var breed = this.Context.Breeds
                .FirstOrDefault(b => b.Name == model.Breed);
                if (breed == null)
                {
                    this.Model.Data["error"] = "Invalid breed";
                    return this.View();
                }

                var kitten = new Kitten()
                {
                    Name = model.Name,
                    Age = model.Age,
                    Breed = breed
                };

                this.Context.Kittens.Add(kitten);
                this.Context.SaveChanges();

                return this.RedirectToAction("/kittens/all");
            }
        }

        [HttpGet]
        [PreAuthorize]
        public IActionResult All()
        {
            var kittens = this.Context.Kittens
                .Include(k => k.Breed)
                .Select(KittenViewModel.FromKitten)
                .Select(vm =>
                    $@"<div class=""col-4"">
                        <img class=""img-thumbnail"" src=""https://images.pexels.com/photos/20787/pexels-photo.jpg?auto=compress&cs=tinysrgb&h=350"" alt=""{vm.Name}'s photo"" />
                        <div>
                            <h5>Name: {vm.Name}</h5>
                            <h5>Age: {vm.Age}</h5>
                            <h5>Breed: {vm.Breed}</h5>
                        </div>
                    </div>")
                .ToList();

            var kittensResult = new StringBuilder();
            kittensResult.Append(@"<div class=""row text-center"">");
            for (int i = 0; i < kittens.Count; i++)
            {
                kittensResult.Append(kittens[i]);

                if (i % KittensPerPage == KittensPerPage - 1)
                {
                    kittensResult.Append(@"</div><div class=""row text-center"">");
                }
            }

            kittensResult.Append("</div>");

            this.Model.Data["kittens"] = kittensResult.ToString();
            return this.View();
        }
    }
}
