using System.Linq;
using FDMC.Data;
using FDMC.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace FDMC.Web.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext _context;

        public HomeController(ApplicationContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {          
            var cats = this._context.Cats
                .Select(e => new CatsViewModel()
                {
                    Id = e.Id,
                    Name = e.Name
                }).ToList();

            return View(cats);
        }
    }
}
