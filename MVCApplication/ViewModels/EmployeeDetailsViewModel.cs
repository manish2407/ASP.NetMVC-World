using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApplication.Models;

namespace MVCApplication.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public Employee1 Employee { get; set; }
        public Address Address { get; set; }
        public string PageTitle { get; set; }
        public string PageHeader { get; set; }
    }
}