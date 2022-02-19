using Microsoft.AspNetCore.Mvc;
using MVCApplication1.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVCApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        private ApplicationDbContext dbContex;
        public EmployeeController(ApplicationDbContext dbContex)
        {
            this.dbContex = dbContex;
        }
        public IActionResult Index()
        {
            List<Employee>emp = dbContex.Employees.ToList();
            return View(emp);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee emps)
        {
            dbContex.Employees.Add(emps);
            dbContex.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
