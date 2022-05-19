using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}