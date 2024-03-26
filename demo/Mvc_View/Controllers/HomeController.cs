using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
            //return View("~/Views/MyView/mynewview.cshtml");
        }
        public ViewResult AboutUs()
        {
            return View("Rename");
        }
        public ActionResult WithoutView()
        {
            return View();
        }
    }
}