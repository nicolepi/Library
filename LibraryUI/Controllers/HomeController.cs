using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryUI.Controllers
{
    public class HomeController : Controller //HomeController is a type of Controller
    {
        public ActionResult Index() //ActionResult is the return type, translate to html and javascript
        {
            return View(); //map html page that matches homecontroller
        }

        
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}