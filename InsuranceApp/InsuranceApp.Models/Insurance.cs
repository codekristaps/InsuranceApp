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
        [Required]
        public Guid InsuranceId { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation property
        public ICollection<InsuranceProduct> InsuranceProducts { get; set; }
    }
}