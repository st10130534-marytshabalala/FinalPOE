using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using st101030534_part1_CLDV7111.Models;

namespace st101030534_part2_CLDV7111.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new MyViewModel
            {
                Products = GetProducts(),
                Artisans = GetArtisans()
            };

            // Group products by artisan
            model.ArtisanProducts = model.Artisans.ToDictionary(
                artisan => artisan,
                artisan => model.Products.Where(p => p.Artisan.Id == artisan.Id).ToList()
            );

            return View(model);
        }

        private List<Product> GetProducts()
        {
            // Example mock data
            return new List<Product>
    {
        new Product { Id = 1, Name = "Product 1", Description = "Description 1", Price = 10.00M, Artisan = new Artisan { Id = 1, Name = "Artisan 1", ImagePath = "1.jfif" } },
        new Product { Id = 2, Name = "Product 2", Description = "Description 2", Price = 20.00M, Artisan = new Artisan { Id = 1, Name = "Artisan 1", ImagePath = "2.jfif" } },
        new Product { Id = 3, Name = "Product 3", Description = "Description 3", Price = 30.00M, Artisan = new Artisan { Id = 2, Name = "Artisan 2", ImagePath = "4.jpg" } }
    };
        }

        private List<Artisan> GetArtisans()
        {
            // Mock data for artisans. Replace with actual data fetching logic.
            return new List<Artisan>
            {
                new Artisan { Id = 1, Name = "John Smith", ImagePath = "1.jfif" },
                new Artisan { Id = 2, Name = "Mary Tshabalala", ImagePath = "2.jfif" }
            };
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    }
}


