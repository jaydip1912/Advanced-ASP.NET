using DataBaseCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace DataBaseCRUD.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
            
        }
        public ActionResult GetEmployees() 
        {
            using (MyDatabaseEntities db = new MyDatabaseEntities())
            {
                var emp = db.Employees.OrderBy(a => a.FirstName).ToList();
                return Json(new {data=emp},JsonRequestBehavior.AllowGet);
            }
        }
        [HttpGet]
        public ActionResult Save(int id) 
        {
            using(MyDatabaseEntities db = new MyDatabaseEntities())
            {
                var v= db.Employees.Where(a =>a.Id==id).FirstOrDefault();
                return View(v);
            }
        }
        
        [HttpPost]
        public ActionResult Save(Employee emp) 
        {
            bool status=false;
            if(ModelState.IsValid) 
            {
                using (MyDatabaseEntities dc = new MyDatabaseEntities()) 
                {
                    if (emp.Id > 0)
                    {

                        //Edit
                        var v = dc.Employees.Where(a => a.Id == emp.Id).FirstOrDefault();
                        if (v != null)
                        {
                            v.FirstName = emp.FirstName;
                            v.LastName = emp.LastName;
                            v.EmailId = emp.EmailId;
                            v.City = emp.City;
                            v.Country = emp.Country;

                        }
                    }
                    else
                    {
                        //save
                        dc.Employees.Add(emp);
                    }
                    dc.SaveChanges();
                    status=true;
                    }
                }
                return new JsonResult { Data=new {status=status} };
            }

        

        [HttpGet]
        public ActionResult Delete(int id) 
        {
            using (MyDatabaseEntities db = new MyDatabaseEntities())
            {
                var v =db.Employees.Where(a=>a.Id == id).FirstOrDefault();  
                if(v!=null)
                {
                return View(v) ;
                }
                else
                {
                    return HttpNotFound();
                }
            }
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult deleteEmployee (int id) 
        {
            bool status = false; 
            using (MyDatabaseEntities db = new MyDatabaseEntities())
            {
                var v= db.Employees.Where(a=>a.Id==id).FirstOrDefault();
                if(v!=null) 
                {
                    db.Employees.Remove(v);
                    db.SaveChanges();
                    status=true;
                }
            }
            return new JsonResult { Data=new { status=status} };
            
        }


    }
}