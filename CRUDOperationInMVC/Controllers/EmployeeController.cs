using CRUDOperationInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDOperationInMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeDBContext dbContext = new EmployeeDBContext();
            List<Employee> empList = dbContext.Employees.ToList();
            return View(empList);
        }
    }
}