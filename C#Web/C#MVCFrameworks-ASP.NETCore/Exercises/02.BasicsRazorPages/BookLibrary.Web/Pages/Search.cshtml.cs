using System.Collections.Generic;
using System.Linq;
using BookLibrary.Data;
using BookLibrary.Web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookLibrary.Web.Pages
{
    public class SearchModel : PageModel
    {
        private BookLibraryContext _context;

        public SearchModel(BookLibraryContext context)
        {
            this._context = context;
            this.SearchResults = new List<SearchViewModel>();
        }

        public List<SearchViewModel> SearchResults { get; set; }

        public string SearchTerm { get; set; }

        public void OnPost(string searchTerm)
        {
            this.SearchTerm = searchTerm;

            this.SearchResults
                .AddRange(this._context.Authors.Where(a => a.Name.Contains(searchTerm))
                .Select(e => new SearchViewModel
                {
                    Name = e.Name,
                    Id = e.Id,
                    Type = e.GetType().Name
                }).ToList());

            this.SearchResults
                .AddRange(this._context.Books.Where(a => a.Title.Contains(searchTerm))
                    .Select(e => new SearchViewModel
                    {
                        Name = e.Title,
                        Id = e.Id,
                        Type = e.GetType().Name
                    }));
        }
    }
}