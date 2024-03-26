using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["myData"] = "Data from index method";
            return View();
        }
        public ActionResult Index2()
        {
            // Session.Abandon();
            ViewBag.myData = TempData["myData"];
            // ViewBag.myData = TempData.Peek("myData");
            TempData.Keep("myData"); //
            return View();
        }
        public ActionResult Index3()
        {
            ViewBag.myData = TempData["myData"];
            return View();
        }
    }
}