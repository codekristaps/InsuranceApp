using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Models
{
    public class Product
    {
        [Key]
        public Guid ProductId { get; set; }

        [Required]
        public Guid InsuranceProductId { get; set; }

        [Required]
        public Guid? CustomerId { get; set; }

        [Required]
        public DateTime? PurchaseDate { get; set; }

        // Navigation properties
        public InsuranceProduct InsuranceProduct { get; set; }
        public InsuranceCustomer? Customer { get; set; }
    }
}
