using CRUDOperationInMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUDOperationInMVC.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index()
        {
            NewEmployeeDbContext dbContext = new NewEmployeeDbContext();
            List<Department> listDepartments = dbContext.Departments.ToList();
            return View(listDepartments);
        }
    }
}