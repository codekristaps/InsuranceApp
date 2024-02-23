using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Models
{
    namespace InsuranceApp.Models
    {
        public class CartItem
        {
            [Key]
            public Guid Id { get; set; }
            [Required]
            public Guid CartId { get; set; }
            [Required]
            public Guid ProductId { get; set; }

            // Navigation property
            public Cart Cart { get; set; }
        }
    }
}
