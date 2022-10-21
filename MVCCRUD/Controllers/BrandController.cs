using DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCCRUD.Controllers
{
    public class BrandController : Controller
    {
        private Context _context { get; set; }

        public BrandController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
            return View();
        }
    }
}
