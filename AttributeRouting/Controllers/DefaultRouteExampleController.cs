using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttributeRouting.Controllers
{
    [RoutePrefix("MyPage")]
    [Route({"action = Index"})]
    public class DefaultRouteExampleController : Controller
    {
        // URL: /MyPage/
        public ActionResult Index()
        {
            ViewBag.Message = "Index Page";
            return View();
        }
        // URL: /MyPage/Contact
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact page";
            return View();
        }
        // URL: /MyPage/About
        public ActionResult About()
        {
            ViewBag.Message = "About";
            return View();
        }
    }
}