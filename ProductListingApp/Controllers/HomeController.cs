using Microsoft.AspNetCore.Mvc;
using ProductListingApp.Data;
using ProductListingApp.Models;
using System.Diagnostics;

namespace ProductListingApp.Controllers
{
    public class HomeController : Controller
    {
        // private variable to access database
        private readonly Database _db;

        // constructor: create new instance of database
        public HomeController()
        {
            _db = new Database();

        }

        // Index view action
        // pass a list of Toys
        public IActionResult Index()
        {

            return View(_db.datatbaseObjects.Values.ToList());
        }

        // Detailed product view action
        // pass a toy
        public IActionResult DetailedProduct(Toy t)
        {
            return View(t);
        }

    }
}
