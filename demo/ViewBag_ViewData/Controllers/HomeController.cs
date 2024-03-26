using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBag_ViewData.Models;

namespace ViewBag_ViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.myData = "Jaydip";
            ViewBag.myList = new List<string>() { "demo1", "demo2", "demo3", "demo4" };
            List<Employee> emplist = new List<Employee>()
            {
                new Employee(){Email="jp56@gmail,com",Id=1,Name="Jaydip"},
                new Employee(){Email="kp07@gmail,com",Id=2,Name="Khushi"},
                new Employee(){Email="vv12@gmail,com",Id=3,Name="vimal"},
                new Employee(){Email="ap@gmail,com",Id=4,Name="amit"},
            };
            ViewBag.myEmpList=emplist;
            return View();
        }
        public ActionResult Demo()
        {
            ViewData["MyKey"] = "This is value for my key ";
            ViewData["MyList"] = new List<string>() { "demo1", "demo2", "demo3", "demo4" };
            return View();  
        }
    
    }
}