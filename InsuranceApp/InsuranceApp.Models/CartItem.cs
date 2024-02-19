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
            public int Id { get; set; }
            public int CartId { get; set; }
            [Required]
            public Guid ProductId { get; set; }

            // Navigation properties
            public Cart Cart { get; set; }
            public InsuranceProduct Product { get; set; }
        }
    }
}
