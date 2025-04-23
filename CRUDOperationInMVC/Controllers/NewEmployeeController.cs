using CRUDOperationInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDOperationInMVC.Controllers
{
    public class NewEmployeeController : Controller
    {
        // GET: NewEmployee
        public ActionResult Index(int departmentId)
        {
            NewEmployeeDbContext dbContext = new NewEmployeeDbContext();
            List<NewEmployee> employees = dbContext.NewEmployees.Where(emp => emp.DepartmentId == departmentId).ToList();
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            NewEmployeeDbContext dbContext = new NewEmployeeDbContext();
            NewEmployee employee = dbContext.NewEmployees.FirstOrDefault(x => x.EmployeeId == id);
            return View(employee);
        }
    }
}