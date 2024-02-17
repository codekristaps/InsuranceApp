using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Models
{
    public class InsuranceProduct
    {
        [Key]
        [Required]
        public Guid InsuranceProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal? Discount { get; set; }

        // Navigation property for products tied to this insurance product
        public ICollection<Product>? Products { get; set; }

        // Foreign key for Insurance
        [Required]
        public Guid InsuranceId { get; set; }

        // Navigation property for Insurance
        public Insurance Insurance { get; set; }
    }
}
