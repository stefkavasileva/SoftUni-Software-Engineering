using KittenApp.Models;
using System;
using System.Linq.Expressions;

namespace KittenApp.Web.Models.ViewModels
{
    public class KittenViewModel
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Breed { get; set; }

        public string PictureUrl { get; set; } = "https://www.catster.com/wp-content/uploads/2017/12/A-kitten-meowing.jpg";

        public static Expression<Func<Kitten, KittenViewModel>> FromKitten =>
            k => new KittenViewModel()
            {
                Name = k.Name,
                Age = k.Age,
                Breed = k.Breed.Name
            };
    }
}
