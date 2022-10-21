using DB.Models;
using Microsoft.AspNetCore.Mvc;

namespace MVCCRUD.Controllers
{
    public class BeerController : Controller
    {
        private Context _context { get; set; }

        public BeerController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.BrandId = BrandList();
            return View();
        }

        [HttpPost]
        public IActionResult IndexPost(Beer beer)
        {
            _context.Beers.Add(beer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public List<Brand> BrandList()
        {
            var list =_context.Brands.ToList();
            return list;
        }
    }
}
