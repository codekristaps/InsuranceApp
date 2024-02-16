using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Models
{
    public class Insurance
    {
        [Key]
        public int InsuranceId { get; set; }

        [Required]
        public string PolicyNumber { get; set; }

        // Foreign key for the related product
        public int ProductId { get; set; }

        // Navigation property for the related product
        public Product Product { get; set; }
    }
}
