using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class InsuranceCustomer : IdentityUser
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        //public string? StreetAddress { get; set; }

        //public string? City { get; set; }

        //public string? State { get; set; }

        //public string? PostalCode { get; set; }

        //[Required]
        //public DateTime BirthDate { get; set; }

        // Navigation property for products purchased by this customer
        public ICollection<Product> Products { get; set; }

        // For the roles
        public IList<string> Roles { get; set; }
        public string? Role { get; set; }
    }
}
