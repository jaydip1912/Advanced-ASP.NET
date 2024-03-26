using Crud_MVC_UsingDatatable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_MVC_UsingDatatable.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetEmployees() 
        {
            using(MyDatabaseEntities1 db =new MyDatabaseEntities1())
            {
                var employees = db.Employees.OrderBy(a => a.FirstName).ToList();
                return Json(new {data=employees},JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult Save(int id)
        {
            using(MyDatabaseEntities1 db=new MyDatabaseEntities1())
            {
                var v=db.Employees.Where(a=>a.EmployeeID==id).FirstOrDefault();
                return View(v);
            }
        }

        [HttpPost]
        public ActionResult Save(Employee emp) 
        {
            bool status=false;
            if(emp.EmployeeID>0) 
            {
                using(MyDatabaseEntities1 db=new MyDatabaseEntities1())
                {
                    if(emp.EmployeeID>0)
                    {
                        var v =db.Employees.Where(a=>a.EmployeeID==emp.EmployeeID).FirstOrDefault();
                        if (v != null)
                        {
                            v.FirstName = emp.FirstName;
                            v.LastName = emp.LastName;
                            v.EmailID = emp.EmailID;
                            v.City = emp.City;
                            v.Country = emp.Country;

                        }
                    }
                    else
                    {
                        db.Employees.Add(emp);  
                    }
                    db.SaveChanges();
                    status=true;
                }
            }
            return new JsonResult { Data=new {status= status} };    
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            using(MyDatabaseEntities1 db= new MyDatabaseEntities1())
            {
                var v=db.Employees.Where(a=>a.EmployeeID == id).FirstOrDefault();
                if(v!= null)
                {
                    return View(v);
                }
                else
                {
                    return HttpNotFound();
                }
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteEmployee(int id)
        {
            bool status = false;
            using (MyDatabaseEntities1 db = new MyDatabaseEntities1())
            {
                var v = db.Employees.Where(a => a.EmployeeID == id).FirstOrDefault();
                if (v != null)
                {
                    db.Employees.Remove(v);
                    db.SaveChanges();
                    status = true;
                }
            }
            return new JsonResult { Data = new { status = status } };
        }
    
    
    }

}