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
        public ViewResult Details()
        {
            //Employee Basic Details
            Employee1 employee = new Employee1()
            {
                EmployeeId = 101,
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
    }
}