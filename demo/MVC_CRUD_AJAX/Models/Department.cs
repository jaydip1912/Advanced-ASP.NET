using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD_AJAX.Models
{
    public class Department
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Code { get; set; }
        public string Note { get; set; }
    }
}