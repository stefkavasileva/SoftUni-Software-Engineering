using FDMC.Data;
using FDMC.Models;
using FDMC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.Web.Controllers
{
    public class CatController : Controller
    {
        private ApplicationContext _context;

        public CatController(ApplicationContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(CatAddBindingModel model)
        {
            if (this.ModelState.IsValid)
            {
                var cat = new Cat
                {
                    Age = model.Age,
                    Breed = model.Breed,
                    ImageUrl = model.ImageUrl,
                    Name = model.Name
                };

                this._context.Cats.Add(cat);
                this._context.SaveChanges();

                return RedirectToAction("Details", "Cat", new {id = cat.Id});
            }

            return this.View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var cat = _context.Cats.Find(id);
            if (cat != null)
            {
                var model = new CatDetailsViewModel
                {
                    Name = cat.Name,
                    Breed = cat.Breed,
                    ImageUrl = cat.ImageUrl,
                    Age = cat.Age
                };

                return this.View(model);
            }

            return NotFound();
        }
    }
}
