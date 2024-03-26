using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Templated_Html_Helpers.Models;

namespace Templated_Html_Helpers.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "jaydip",
                DateofBirth = DateTime.Now,
                Email = "jaydip980@gmail.com",
                IsOnline = true
            };
            return View(emp);
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            return View();
        }
    }
}