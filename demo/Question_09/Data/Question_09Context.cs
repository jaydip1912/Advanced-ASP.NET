using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Question_09.Data
{
    public class Question_09Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Question_09Context() : base("name=Question_09Context")
        {
        }

        public System.Data.Entity.DbSet<Question_09.Models.Employee> Employees { get; set; }
    }
}
