using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Model.Models;

namespace Mvc_Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }
        private Employee GetEmployee()
        {
            return new Employee()
            {
                Id=1,
                Address="India",
                Name="jaydip"
            };
        }
    }
}