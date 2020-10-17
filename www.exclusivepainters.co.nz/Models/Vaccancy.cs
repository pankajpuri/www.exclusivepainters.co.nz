using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace www.exclusivepainters.co.nz.Models
{
    public class Vaccancy
    {
        [Key]
        [ForeignKey("EmployeeForm")]
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PerHour { get; set; }

        public virtual EmployeeForm EmployeeForm { get; set; }
    }
}