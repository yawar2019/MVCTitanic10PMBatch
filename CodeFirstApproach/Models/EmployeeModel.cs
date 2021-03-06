using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstApproach.Models
{
   
    public class EmployeeModel
    {
        [Key]
        public int EmpId { get; set; }
        [Display(Name ="Employee Name")]
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }
        public string Designation { get; set; }
        public bool Status { get; set; }
    }
}