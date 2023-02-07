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

        


    }
}
