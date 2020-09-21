using Microsoft.AspNetCore.Mvc;
using ProductCatolog.DAO;

namespace ProductCatolog.Controllers
{
    public class Product : Controller
    {
        // ref to db
        private readonly ProductDbContext _context;
        public Product(ProductDbContext context)
        {
            _context = context;
        }
        // list all
        public IActionResult Index()
        {
            return Content("List All");
        }
        // display form to add
        public IActionResult CreateForm()
        {
            return Content("Create Product");
        }
        // add to db
        public IActionResult Add()
        {
            return Content("Add Product to DB");
        }
    }
}