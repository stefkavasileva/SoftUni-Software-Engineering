using BookLibrary.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Web.Models
{
    public class BasePageModel : PageModel
    {
        protected BookLibraryContext _context;

        public BasePageModel(BookLibraryContext context)
        {
            this._context = context;
        }   
    }
}
