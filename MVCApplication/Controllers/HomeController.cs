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
        //When adding the Controller and run it By default it will show "The view 'Index' or its master was not found or no view engine supports the searched locations"
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //to check the controller is working or not we have changed the return type and run it.
        //public string Index()
        //{
        //    return "Hello MVC 5 Application";
        //}

        //checking Controller with Id parameter in the actionResult
        //public string Index(string id)
        //{
        //    return "The value of  Id = " + id;
        //}

        //checking Controller by passing Id and name parameter in the actionResult
        //public string Index(string id, string name)
        //{
        //    return "The value of  Id = " + id + " and Name = " + name;
        //}

        //checking Controller by passing Id and name parameter and using Request.QueryString in the actionResult
        public string Index(string id, string name)
        {
            return "Id = " + id + " ,Name = " + Request.QueryString["name"];
        }
    }
}