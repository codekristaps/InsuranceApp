using System.Collections.Generic;

namespace InsuranceApp.Models
{
    public class CreateInsuranceProductViewModel
    {
        public InsuranceProduct InsuranceProduct { get; set; }
        public List<Insurance> Insurances { get; set; }
    }
}