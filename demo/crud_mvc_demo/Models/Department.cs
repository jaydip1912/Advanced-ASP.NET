using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace crud_mvc_demo.Models
{
    public class Department
    {
        public int Id { get; set; } 
        public int Name { get; set;}
        public string Code { get; set;}
        public string Note { get; set;}
    }
}