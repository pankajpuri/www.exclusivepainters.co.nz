using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace www.exclusivepainters.co.nz.Models
{
    public class ContactForm
    {
        [Required, Display(Name = "Sender Name")]
        public string SenderName { get; set; }
        [Required, Display(Name = "Sender Email"), EmailAddress]
        public string SenderEmail { get; set; }
        [Required]
        public string Mobile { get; set; }
        [Required]
        public string Message { get; set; }
    }
}