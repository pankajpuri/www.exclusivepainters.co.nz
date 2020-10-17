using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace www.exclusivepainters.co.nz.Models
{
    public class Address
    { 
        [Key]
        public int AddressId { get; set; }
        [ForeignKey("EmployeeForm")]
        public int EmployeeId { get; set; }
        [ForeignKey("Job")]
        public int JobId { get; set; }

        public string Flat { get; set; }
        public string HouseNumber{ get; set; }
        public string StreetName{ get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }
        
        public virtual EmployeeForm EmployeeForm { get; set; }
        public virtual Job Job { get; set; }

    }
}