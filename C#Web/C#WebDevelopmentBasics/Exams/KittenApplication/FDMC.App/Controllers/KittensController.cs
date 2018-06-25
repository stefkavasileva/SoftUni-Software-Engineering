using System.Collections.Generic;
using System.Linq;
using System.Text;
using FDMC.App.Models.BindingModels;
using FDMC.App.Models.ViewModel;
using FDMC.Models;
using Microsoft.EntityFrameworkCore;
using SimpleMvc.Framework.Attributes.Methods;
using SimpleMvc.Framework.Interfaces;

namespace FDMC.App.Controllers
{
    public class KittensController : BaseController
    {
        [HttpGet]
        public IActionResult Add() => this.View();

        [HttpPost]
        public IActionResult Add(KittenAddBidingModel model)
        {
            if (!this.User.IsAuthenticated)
            {
                return RedirectToAction("/users/login");
            }

            if (!this.IsValidModel(model))
            {
                if (string.IsNullOrWhiteSpace(model.Name))
                {
                    this.Model.Data["error"] = "Name is required";
                }
                else if (string.IsNullOrWhiteSpace(model.Bread))
                {
                    this.Model.Data["error"] = "Bread is required";
                }

                return this.View();
            }

            if (model.Bread != "Street Transcended" && model.Bread != "American Shorthair" &&
                model.Bread != "Munchkin" && model.Bread != "Siamese")
            {
                this.Model.Data["error"] =
                    "Valid bread are: Siamese, Munchkin, American Shorthair and Street Transcended";

                return View();
            }

            using (this.Context)
            {
                var currentUser = this.Context.Users.FirstOrDefault(u => u.Username == this.User.Name);
                var kitten = new Kitten
                {
                    Age = model.Age,
                    Breed = model.Bread,
                    Name = model.Name,
                    OwnerId = currentUser.Id
                };

                this.Context.Kittens.Add(kitten);
                this.Context.SaveChanges();
            }

            return RedirectToAction("/kittens/all");
        }

        [HttpGet]
        public IActionResult All()
        {
            var kittens = new List<KittenViewModel>();
            using (this.Context)
            {
                kittens = this.Context.Kittens
                   .Include(x => x.Owner)
                   .Where(x => x.Owner.Username == this.User.Name)
                   .Select(x => new KittenViewModel
                   {
                       Name = x.Name,
                       Age = x.Age,
                       Bread = x.Breed,
                       ImagePath = "https://www.google.bg/url?sa=i&rct=j&q=&esrc=s&source=imgres&cd=&cad=rja&uact=8&ved=2ahUKEwiAyK-D5ezbAhXDL1AKHZPOCgUQjRx6BAgBEAU&url=http%3A%2F%2Fwww.imotisiana.com%2Fblog%2F%25D0%25BA%25D0%25BE%25D1%2582%25D0%25BA%25D0%25B0%2F&psig=AOvVaw1YaiEHOCIXl4HpCp0AKRic&ust=1529946509592409",
                   }).ToList();
            }

            var result = new StringBuilder();

            for (int i = 0; i < kittens.Count; i++)
            {
                result.Append($@"<div>
                    <img class=""img-thumbnail"" src=""{kittens[i].ImagePath}"">
                    <p>Name:{kittens[i].Name}</p>
                    <p>Age:{kittens[i].Age}</p>
                    <p>Bread:{kittens[i].Bread}</p>
                    </div>");
            }

            this.Model.Data["cats"] = result.ToString();
            return this.View();
        }
    }
}
