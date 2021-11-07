using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace www.exclusivepainters.co.nz.ViewModels
{
    public class Login
    {
        public int Id { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email id is required.")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        // [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}