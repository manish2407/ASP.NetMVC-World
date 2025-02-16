using MVCApplication.Models;
using MVCApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication.Controllers
{
    public class EmployeeController : Controller
    {
        //Passing and retrieving data from Controller to view using ViewModel
        public ViewResult Details( int id)
        {
            //Employee Basic Details
            Employee1 employee = new Employee1()
            {
                EmployeeId = id,
                Name = "Manish",
                Gender = "Male",
                Department = "CS",
                Salary = 10000,
                AddressId = 1001
            };
            //Employee Address
            Address address = new Address()
            {
                AddressId = 1001,
                City = "Hathras",
                State = "Uttar Pradesh",
                Country = "India",
                Pin = "204101"
            };
            //Creating the View model
            EmployeeDetailsViewModel employeeDetailsViewModel = new EmployeeDetailsViewModel()
            {
                Employee = employee,
                Address = address,
                PageTitle = "Employee Details Page using ViewModel",
                PageHeader = "Employee Details using ViewModel",
            };
            //Pass the employeeDetailsViewModel to the view
            return View(employeeDetailsViewModel);
        }

        //Passing and retrieving data from Controller to view using TempData
        //public ActionResult Method1()
        //{
        //    TempData["Name"] = "Manish";
        //    TempData["Age"] = 25;
        //    TempData.Keep();
        //    return View();
        //}
        //public ActionResult Method2()
        //{
        //    string Name = null;
        //    int Age = 0;
        //    if (TempData.ContainsKey("Name"))
        //        Name = TempData["Name"].ToString();
        //    if (TempData.ContainsKey("Age"))
        //        Age = int.Parse(TempData["Age"].ToString());

        //    TempData.Keep();
        //    return View();
        //}
        //public ActionResult Method3()
        //{
        //    string Name;
        //    int Age;
        //    if (TempData.ContainsKey("Name"))
        //        Name = TempData["Name"].ToString();
        //    if (TempData.ContainsKey("Age"))
        //        Age = int.Parse(TempData["Age"].ToString());
        //    // do something with userName or userAge here 
        //    return View();
        //}
    }
}