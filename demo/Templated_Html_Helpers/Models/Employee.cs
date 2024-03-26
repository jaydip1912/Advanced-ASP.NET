using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Templated_Html_Helpers.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Display(Name="Please enter your name")]
        public string Name { get; set; }
        public string Email { get; set; }
        public bool IsOnline { get; set; }
        [Display(Name ="Please enter DateofBirth")]
        [DataType(DataType.Date)]
        public DateTime DateofBirth { get; set; }
        [DataType(DataType.Time)]
        public DateTime BirthTime { get; set; }
    }
}