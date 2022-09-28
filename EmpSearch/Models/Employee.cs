using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmpSearch.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Emp Code")]
        public string EmpCode { get; set; }
        [Display(Name = "Emp Name")]
        public string EmpName { get; set; }
        public DateTime Dob { get; set; }
        public string Department { get; set; }
        [Display(Name = "Report To")]
        public string ReportTo { get; set; }
        [Display(Name = "Contact No")]
        public long ContactNo { get; set; }
        public string Resigned { get; set; }
        [Display(Name = "Resigned Date")]
        public DateTime ResignedDate { get; set; }

    }
}