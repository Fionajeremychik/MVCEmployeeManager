using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCEmployeeManager.Models;

namespace MVCEmployeeManager.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _db;

        public EmployeesController(AppDbContext db)
        {
            _db = db;
        }

        // GET: Employees
        public IActionResult List()
        {
            // Use Linq
            List<Employee> model = (from e in _db.Employees
                                    orderby e.EmployeeID
                                    select e).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Insert()
        {
            FillCountries();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Insert(Employee model)
        {
            FillCountries();
            if (ModelState.IsValid)
            {
                _db.Employees.Add(model);
                _db.SaveChanges();
                ViewBag.Message = "Employee added successfully";
            }
            return View(model);

        }

        // drop down menu
        private void FillCountries()
        {
            List<SelectListItem> listOfCountries = (from c in _db.Employees
                                                    select new SelectListItem()
                                                    {
                                                        Text = c.Country,
                                                        Value = c.Country
                                                    }).Distinct().ToList();
            // store data into ViewBag and pass it to the view
            ViewBag.Countries = listOfCountries;
        }
    }
}
