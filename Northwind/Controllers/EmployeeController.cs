using Microsoft.AspNetCore.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly NortwindZ35SabahContext _db;

        public EmployeeController(NortwindZ35SabahContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var result = _db.Employees.ToList();
            return View(result);
        }

        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                _db.Employees.Add(emp);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }

        }
    }
}
