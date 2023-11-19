using Microsoft.AspNetCore.Mvc;
using ProductListingApp.Data;
using ProductListingApp.Models;
using System.Diagnostics;

namespace ProductListingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly Database _db;
        public HomeController()
        {
            _db = new Database();

        }

        public IActionResult Index()
        {

            return View(_db.datatbaseObjects.Values.ToList());
        }

    }
}
