using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DataBaseCRUD.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {
          
    }
    public class EmployeeMetadata
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please Enter Firstname")]

        public String FirstName { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please Enter Lastname")]
        public String LastName { get; set; }
    }
}