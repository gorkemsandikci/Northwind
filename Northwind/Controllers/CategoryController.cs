using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NortwindZ35SabahContext _db;

        public CategoryController(NortwindZ35SabahContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var result = _db.Categories.ToList();
         
            return View(result);
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category cat)
        {

            if (ModelState.IsValid)
            {
                _db.Categories.Add(cat);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(cat);
            }

        }
    }
}
