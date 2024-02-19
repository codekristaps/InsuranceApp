using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceApp.Models
{
    public class Insurance
    {
        [Key]
        public Guid InsuranceId { get; set; }

        [Required]
        public string Name { get; set; }

        // Navigation property
        [NotMapped]
        public ICollection<InsuranceProduct> InsuranceProducts { get; set; }
    }
}