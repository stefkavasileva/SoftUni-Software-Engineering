using System.Collections.Generic;
using System.Linq;
using BookLibrary.Data;
using BookLibrary.Models;
using BookLibrary.Web.Models;
using BookLibrary.Web.Models.BindingModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Web.Controllers
{
    public class DirectorController : BaseController
    {
        public DirectorController(BookLibraryContext context)
            : base(context)
        {
        }

        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(AddDirectorBindingModel model)
        {
            if (ModelState.IsValid)
            {
                var director = new Director { Name = model.Name };
                this._context.Directors.Add(director);
                this._context.SaveChanges();
                return RedirectToPage("/Index");
            }

            return this.View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var director = this._context.Directors.Include(a => a.Movies).FirstOrDefault(a => a.Id == id);
            if (director is null) return NotFound();

            var model = new DirectorDetailsViewModel
            {
                Name = director.Name,
                Movies = director.Movies.Select(b => new MovieByAuthorViewModel
                {
                    Title = b.Title,
                    Id = b.Id,
                    Status = b.IsBorrowed ? "Borrowed" : "At home",
                }).ToList()
            };

            return this.View(model);
        }
    }
}