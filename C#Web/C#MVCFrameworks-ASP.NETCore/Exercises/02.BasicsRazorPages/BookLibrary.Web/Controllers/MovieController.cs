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
    public class MovieController : BaseController
    {
        public MovieController(BookLibraryContext context)
            : base(context)
        {
        }

        [HttpGet]
        public IActionResult Add()
        {
            return this.View();
        }

        [HttpPost]
        public IActionResult Add(AddMovieBindingModel model)
        {
            if (ModelState.IsValid)
            {
                var movie = new Movie();
                movie.Title = model.Title;

                var director = _context.Directors.FirstOrDefault(a => a.Name == model.Director);
                if (director is null)
                {
                    director = new Director { Name = model.Director };
                    this._context.Directors.Add(director);
                    this._context.SaveChanges();
                }

                movie.DirectorId = director.Id;
                movie.PosterImageUrl = model.PosterImageUrl;
                movie.Description = model.Description;

                this._context.Movies.Add(movie);
                this._context.SaveChanges();

                return RedirectToAction("Details", new { id = movie.Id });
            }

            return this.View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var movieDb = _context.Movies.Include(b => b.Director).FirstOrDefault(b => b.Id == id);

            if (movieDb is null) return NotFound();

            var model = new MovieDetailsViewModel
            {
                Director = movieDb.Director.Name,
                Status = movieDb.IsBorrowed ? "Borrowed" : "At home",
                Title = movieDb.Title,
                Description = movieDb.Description,
                PosterUrl = movieDb.PosterImageUrl,
                Id = movieDb.Id
            };

            return this.View(model);
        }

        [HttpGet]
        public IActionResult Borrow()
        {
            var model = new BorrowBindingModel();
            return this.View(model);
        }

        [HttpPost]
        public IActionResult Borrow(BorrowBindingModel model, int id)
        {
            if (!ModelState.IsValid || model.StartDate > model.EndDate)
            {
                return this.View();
            }

            var borrower = this._context
                .Borrowers
                .FirstOrDefault(x => x.Name.Equals(model.BorrowerName));

            if (borrower == null)
            {
                borrower = new BookLibrary.Models.Borrower { Name = model.BorrowerName };

                this._context.Borrowers.Add(borrower);
                this._context.SaveChanges();
            }

            var movie = this._context.Movies.Find(id);

            if (movie == null)
            {
                return this.View();
            }

            this._context.MovieBorrowerses.Add(new MovieBorrowers()
            {
                MovieId = movie.Id,
                BorrowDate = model.StartDate,
                BorrowerId = borrower.Id,
                ReturnDate = model.EndDate
            });

            movie.IsBorrowed = true;
            this._context.SaveChanges();
            return RedirectToAction("Details","Movie", new { id = id });
        }

        [HttpGet]
        public IActionResult ReturnMovie(int id)
        {
            var movie = this._context.Movies.Find(id);

            if (movie == null)
            {
                return NotFound();
            }

            movie.IsBorrowed = false;
            this._context.SaveChanges();

            return RedirectToAction("Details", new { id = movie.Id });
        }

        public IActionResult Status(int id)
        {        
            var borrowedMovies = this._context.MovieBorrowerses
                .Include(e => e.Movie)
                .Include(e => e.Borrower)
                .Where(e => e.MovieId == id)
                .ToList();

            var movieTitle = this._context.Movies.Find(id).Title;
         
            var result = new List<StatusViewModel>();

            foreach (var movieBorrowerse in borrowedMovies)
            {
                var period = movieBorrowerse.BorrowDate.ToString("yyyy-MM-dd") + " : " + movieBorrowerse.ReturnDate.ToString("yyyy-MM-dd");
                result.Add(new StatusViewModel
                {
                    BorrowerName = movieBorrowerse.Borrower.Name,
                    Period = period,
                });
            }

            var model = new MovieStatusViewModel
            {
                Title = movieTitle,
                Statuses = result
            };

            return this.View(model);
        }

        [HttpGet]
        public IActionResult DeleteMovie(int id)
        {
            var movieDb = this._context.Movies.Find(id);

            if (movieDb == null)
            {
                return NotFound();
            }

            this._context.Movies.Remove(movieDb);

            var borrowerMovies = this._context.MovieBorrowerses.Where(e => e.MovieId == id).ToList();
            if (borrowerMovies.Any())
            {
                this._context.MovieBorrowerses.RemoveRange(borrowerMovies);
            }

            this._context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
