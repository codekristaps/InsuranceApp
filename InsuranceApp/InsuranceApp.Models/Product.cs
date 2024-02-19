using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Required]
        public DateTime? ExpirationDate { get; set; }
        [Required]
        public decimal PurchasePrice { get; set; }
        [Required]
        public decimal? Discount { get; set; }
        
        // New property for marketing campaign, to track where the customer came from??
        public string? MarketingCampaign { get; set; }

        // Navigation properties
        public InsuranceProduct InsuranceProduct { get; set; }
        [NotMapped]
        public InsuranceCustomer? Customer { get; set; }
    }
}
