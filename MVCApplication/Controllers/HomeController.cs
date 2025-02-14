using MVCApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //1. When adding the Controller and run it By default it will show "The view 'Index' or its master was not found or no view engine supports the searched locations"
        //To resolve this issue we need to have the view related to it.
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //2. to check the controller is working or not we have changed the return type and run it.
        //public string Index()
        //{
        //    return "Hello MVC 5 Application";
        //}

        //3. checking Controller with Id parameter in the actionResult
        //public string Index(string id)
        //{
        //    return "The value of  Id = " + id;
        //}

        //4. checking Controller by passing Id and name parameter in the actionResult
        //public string Index(string id, string name)
        //{
        //    return "The value of  Id = " + id + " and Name = " + name;
        //}

        //5. checking Controller by passing Id and name parameter and using Request.QueryString in the actionResult
        //public string Index(string id, string name)
        //{
        //    return "Id = " + id + " ,Name = " + Request.QueryString["name"];
        //}

        //6. checking Controller by adding model and views in the separate folder
        //public ActionResult Index(int id)
        //{
        //    EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
        //    Employee employee = employeeBL.GetEmployeeDetails(id);
        //    return View();
        //}

        //7. checking Controller by adding model and views in the separate folder and getting data using ViewData
        //public ActionResult Index()
        //{
        //    EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
        //    Employee employee = employeeBL.GetEmployeeDetails(102);

        //    ViewData["Employee"] = employee;
        //    ViewData["Header"] = "Getting Employee Details using ViewData";
        //    return View();
        //}

        //8. checking Controller by adding model and views in the separate folder and getting data using ViewBag
        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBL = new EmployeeBusinessLayer();
            Employee employee = employeeBL.GetEmployeeDetails(102);

            ViewBag.Employee = employee;
            ViewBag.Header = "Getting Employee Details using ViewBag";
            return View();
        }
    }
}