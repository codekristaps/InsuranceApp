using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsuranceApp.Models
{
    public class Cart
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid CustomerId { get; set; }
        [Required]
        public Guid ProductId { get; set; }

        // Navigation property
        [ForeignKey("ProductId")]
        public virtual InsuranceProduct InsuranceProduct { get; set; }
    }
}