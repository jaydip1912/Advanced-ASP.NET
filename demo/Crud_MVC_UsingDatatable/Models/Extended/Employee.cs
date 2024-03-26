using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Crud_MVC_UsingDatatable.Models
{
    public partial class Employee
    {

    }

    public class EmployeeMetadata
    { 
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please enter first name")]
        public string FirstName{ get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please enter last nawe")]
        public string LastName {  get; set; }    
    
    }
}