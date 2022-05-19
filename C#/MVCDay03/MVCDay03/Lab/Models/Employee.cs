using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Lab.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public int? Salary { get; set; }
        [ForeignKey("Department")]
        public int? DeptID { get; set; }
        public virtual Department Department { get; set; }
    }
}