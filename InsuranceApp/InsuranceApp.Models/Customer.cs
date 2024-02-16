using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace InsuranceApp.Models
{
    public class Customer : IdentityUser
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? StreetAddress { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? PostalCode { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
