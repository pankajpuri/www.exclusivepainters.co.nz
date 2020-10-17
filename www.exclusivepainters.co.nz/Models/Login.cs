using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace www.exclusivepainters.co.nz.Models
{
    public class Login
    {
        [Key]
        [ForeignKey("EmployeeForm")]
        public int EmployeeId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Administrator { get; set; }

        public virtual EmployeeForm EmployeeForm { get; set; }
    }
}