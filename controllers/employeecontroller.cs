using Microsoft.AspNetCore.Mvc;
using EmployeeApp.Models;

namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Employee saved successfully!";
            }

            return View();
        }
    }
}
