using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Controller.Controllers
{
    public class HomeController : Controller
    {

        public string Index()
        {
            return "Hello from Home Controller";
        }
        public string Name()
        {
            return "My name is Jaydip";
        }
    }
}