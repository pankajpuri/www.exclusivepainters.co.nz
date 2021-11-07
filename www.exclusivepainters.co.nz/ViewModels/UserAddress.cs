using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace www.exclusivepainters.co.nz.ViewModels
{
    public class UserAddress
    {
        [Key]
        public int AddressId { get; set; }
        [Required(ErrorMessage = "Flat number is Required.")]
        public string Flat { get; set; }
        [Required(ErrorMessage = "House number is Required.")]
        public string HouseNumber { get; set; }
        [Required(ErrorMessage = "Street name is Required.")]
        public string StreetName { get; set; }
        [Required(ErrorMessage = "Suburb name is Required.")]
        public string Suburb { get; set; }
        [Required(ErrorMessage = "City name is Required.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Postal code  is Required.")]
        public int PostalCode { get; set; }

        public int Id { get; set; }
    }
}