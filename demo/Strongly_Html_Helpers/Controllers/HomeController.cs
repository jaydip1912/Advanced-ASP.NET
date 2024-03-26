using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using Strongly_Html_Helpers;
using Strongly_Html_Helpers.Models;

namespace Strongly_Html_Helpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Address = "this is my address",
                IsEmployee = true,
                Name = "Jaydip",
            };
            return View(emp);
        }
        [HttpPost]
        public ActionResult Index(Employee emp)
        {
            return View();
        }
    }
}