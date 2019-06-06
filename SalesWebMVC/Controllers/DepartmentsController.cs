using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;
using System.Collections.Generic;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> allDepartments = new List<Department>();
            allDepartments.Add(new Department(1, "Eletrônicos"));
            allDepartments.Add(new Department(2, "Tools"));
            return View(allDepartments);
        }
    }
}