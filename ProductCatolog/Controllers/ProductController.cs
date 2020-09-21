using Microsoft.AspNetCore.Mvc;

namespace ProductCatolog.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return Content("List All");
        }
        public IActionResult CreateForm()
        {
            return Content("Create Product");
        }
        public IActionResult Add()
        {
            return Content("Add Product to DB");
        }
    }
}