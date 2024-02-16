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
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public ProductType Type { get; set; }

        // Define other relevant properties such as coverage details, pricing, etc.
        // For example:
        [Required]
        public decimal Price { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; } // generated for 1 year after purchase date
    }

    public enum ProductType
    {
        LifeInsurance,
        HealthInsurance,
        CarInsurance,
        HomeInsurance,
        // Add more types as needed
    }
}
