using Microsoft.AspNetCore.Mvc;
using ProductListingApp.Models;

namespace ProductListingApp.Controllers
{
    public class DetailedProductController : Controller
    {
        public IActionResult Index(Toy t)
        {
            
            return View(t);
        }
    }
}
