using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "My first ASP.NET MVC 5 application.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Find Laura Moon:";

            return View();
        }
    }
}