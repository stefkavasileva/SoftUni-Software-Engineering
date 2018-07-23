using BookLibrary.Data;
using Microsoft.AspNetCore.Mvc;

namespace BookLibrary.Web.Controllers
{
    public class BaseController : Controller
    {
        protected BookLibraryContext _context;

        public BaseController(BookLibraryContext context)
        {
            this._context = context;
        }
    }
}