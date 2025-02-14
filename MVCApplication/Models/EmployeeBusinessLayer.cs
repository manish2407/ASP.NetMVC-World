using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApplication.Models
{
    public class EmployeeBusinessLayer
    {
        public Employee GetEmployeeDetails(int EmployeeId)
        {
            //Here we hardcoded the data
            //later we will discuss how to retrieve
            //the data from a database
            Employee employee = new Employee()
            {
                EmployeeId = EmployeeId,
                Name = "Manish",
                Gender = "Male",
                City = "Gurugram",
                Salary = 10000,
                Address = "Sector 21"
            };
            return employee;
        }
    }
}