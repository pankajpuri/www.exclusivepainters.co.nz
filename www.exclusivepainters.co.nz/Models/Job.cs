using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace www.exclusivepainters.co.nz.Models
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }

        public virtual Status Status { get; set; }
        public virtual Address Address { get; set; }
    }
}